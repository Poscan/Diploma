using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Diploma.Requests;
using Diploma.Responses;
using Diploma.Services;
using Microsoft.AspNetCore.Mvc;

namespace Diploma.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ConferencesController : ControllerBase
    {
        private readonly IConferenceService _conferenceService;

        public ConferencesController(IConferenceService conferenceService)
        {
            _conferenceService = conferenceService ?? throw new ArgumentNullException(nameof(conferenceService));
        }

        [HttpGet]
        public ActionResult<IEnumerable<ConferenceResponse>> GetConferences()
        {
            try
            {
                var conferences = _conferenceService.GetConferences();

                return Ok(conferences);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return BadRequest("Ошибка при получении списка конференций: " + e.Message);
            }
        }

        [HttpGet("{id}")]
        public ActionResult<ConferenceResponse> GetConferenceById([FromRoute] long id)
        {
            try
            {
                var conferences = _conferenceService.GetConferenceById(id);

                return Ok(conferences);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return BadRequest("Ошибка отсутствует конференция с данным id: " + id + " " + e.Message);
            }
        }

        [HttpPost]
        public async Task<ActionResult> SaveConference(ConferenceRequest conference)
        {
            try
            {
                var conferenceForSave = await _conferenceService.SaveConference(conference);
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