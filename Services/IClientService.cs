using System.Collections.Generic;
using System.Threading.Tasks;
using Diploma.Requests;
using Diploma.Responses;

namespace Diploma.Services
{
    public interface IClientService
    {
        IEnumerable<ClientResponse> GetClients();
        ClientResponse GetClientById(long id);
        Task<long> SaveClient(ClientRequest client);
    }
}