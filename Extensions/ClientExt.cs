using System.Globalization;
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
                FirstName = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(client.FirstName),
                LastName = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(client.LastName),
                SecondName = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(client.SecondName),
            };
        }
    }
}
