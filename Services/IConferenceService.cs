using System.Collections.Generic;
using System.Threading.Tasks;
using Diploma.Requests;
using Diploma.Responses;

namespace Diploma.Services
{
    public interface IConferenceService
    {
        IEnumerable<ConferenceResponse> GetConferences();
        ConferenceResponse GetConferenceById(long id);
        Task<long> SaveConference(ConferenceRequest conference);
    }
}