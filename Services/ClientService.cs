using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Diploma.Domains;
using Diploma.Extensions;
using Diploma.Requests;
using Diploma.Responses;

namespace Diploma.Services
{
    public class ClientService : IClientService
    {
        public IEnumerable<ClientResponse> GetClients()
        {
            using (var db = new ApplicationContext())
            {
                var clients = db.Clients.ToList();

                return clients.Select(x => x.MapToResponse());
            }
        }

        public ClientResponse GetClientById(long id)
        {
            using (var db = new ApplicationContext())
            {
                var client = db.Clients.Single(x => x.Id == id);

                return client.MapToResponse();
            }
        }

        public async Task<long> SaveClient(ClientRequest client)
        {
            using (var db = new ApplicationContext())
            {
                var clientForSave = db.Clients.SingleOrDefault(x => x.Id == client.Id) ?? new Client();

                clientForSave.FirstName = client.FirstName;
                clientForSave.LastName = client.LastName;
                clientForSave.SecondName = client.SecondName;

                if (clientForSave.Id == 0) await db.Clients.AddAsync(clientForSave);

                await db.SaveChangesAsync();

                return clientForSave.Id;
            }
        }
    }
}