using Diploma.Domains;
using Diploma.Responses;

namespace Diploma.Extensions
{
    public static class ConferenceExt
    {
        public static ConferenceResponse MapToResponse(this Conference conference, ClientResponse client)
        {
            return new ConferenceResponse
            {
                Id = conference.Id,
                Name = conference.Name,
                Description = conference.Description,
                CountParticipants = conference.CountParticipants,
                PictureUrl = conference.PictureUrl,
                Owner = client,
            };
        }
    }
}
