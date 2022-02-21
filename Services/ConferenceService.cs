using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Diploma.Domains;
using Diploma.Extensions;
using Diploma.Requests;
using Diploma.Responses;

namespace Diploma.Services
{
    public class ConferenceService : IConferenceService
    {
        private readonly IClientService _clientService;

        public ConferenceService(IClientService clientService)
        {
            _clientService = clientService ?? throw new ArgumentNullException(nameof(clientService));
        }

        public IEnumerable<ConferenceResponse> GetConferences()
        {
            using (var db = new ApplicationContext())
            {
                var conferences = db.Conferences.ToList();

                var conferenceResponses =
                    conferences.Select(x => x.MapToResponse(_clientService.GetClientById(x.OwnerId)));

                return conferenceResponses;
            }
        }

        public ConferenceResponse GetConferenceById(long id)
        {
            using (var db = new ApplicationContext())
            {
                var conference = db.Conferences.Single(x => x.Id == id);

                var client = _clientService.GetClientById(conference.OwnerId);
                var conferenceResponse = conference.MapToResponse(client);

                return conferenceResponse;
            }
        }

        public async Task<long> SaveConference(ConferenceRequest conference)
        {
            using (var db = new ApplicationContext())
            {
                var conferenceForSave = db.Conferences.SingleOrDefault(x => x.Id == conference.Id) ?? new Conference();

                conferenceForSave.Name = conference.Name;
                conferenceForSave.Description = conference.Description;
                conferenceForSave.PictureUrl = conference.PictureUrl;
                conferenceForSave.CountParticipants = conference.CountParticipants;
                conferenceForSave.OwnerId = conference.Owner.Id;

                if (conferenceForSave.Id == 0) await db.Conferences.AddAsync(conferenceForSave);

                await db.SaveChangesAsync();
                return conferenceForSave.Id;
            }
        }
    }
}