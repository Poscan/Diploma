using Diploma.Domains;
using Diploma.Responses;

namespace Diploma.Extensions
{
    public static class ClientExt
    {
        public static ClientResponse MapToResponse(this Client client)
        {
            return new ClientResponse
            {
                Id = client.Id,
                FirstName = client.FirstName,
                LastName = client.LastName,
                SecondName = client.SecondName,
            };
        }
    }
}
