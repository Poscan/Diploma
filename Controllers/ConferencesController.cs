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
    [Route("api/[controller]")]
    public class ConferencesController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<Conference>> GetConferences()
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                try
                {
                    var conferences = db.Conferences.ToList();

                    return Ok(conferences);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    return BadRequest("Ошибка при получении списка конференций: " + e.Message);
                }
            }
        }

        [HttpPost]
        public async Task<ActionResult> SaveConference(Conference conference)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                try
                {
                    var conferenceForSave = db.Conferences.SingleOrDefault(x => x.Id == conference.Id) ?? new Conference();

                    conferenceForSave.Name = conference.Name;
                    conferenceForSave.Description = conference.Description;
                    conferenceForSave.PictureUrl = conference.PictureUrl;
                    conferenceForSave.CountParticipants = conference.CountParticipants;

                    if (conferenceForSave.Id == 0)
                    {
                        await db.Conferences.AddAsync(conferenceForSave);
                    }

                    await db.SaveChangesAsync();
                    return Ok();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);

                    return BadRequest("Ошибка при добавлении новой конференции: " + e.Message);
                }
            }
        }
    }
}
