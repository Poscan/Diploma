using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Diploma.Domains;
using Microsoft.AspNetCore.Mvc;
using Npgsql;

namespace Diploma.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MeetupsController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<Meetup>> GetMeetups()
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                try
                {
                    var meetups = db.Meetups.ToList();

                    return Ok(meetups);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    return BadRequest("Ошибка при получении списка событий: " + e.Message);
                }
            }
        }

        [HttpPost]
        public async Task<ActionResult> SaveMeetup(Meetup meetup)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                try
                {
                    var meetupForSave = db.Meetups.SingleOrDefault(x => x.Id == meetup.Id) ?? new Meetup();

                    meetupForSave.Name = meetup.Name;
                    meetupForSave.CountSignedUp = meetup.CountSignedUp;
                    meetupForSave.Description = meetup.Description;

                    if (meetupForSave.Id == 0)
                    {
                        await db.Meetups.AddAsync(meetupForSave);
                    }

                    await db.SaveChangesAsync();
                    return Ok();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);

                    return BadRequest("Ошибка при добавлении нового события: " + e.Message);
                }
            }
        }
    }
}
