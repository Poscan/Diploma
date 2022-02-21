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
    public class ClientController : ControllerBase
    {
        private readonly IClientService _clientService;

        public ClientController(IClientService clientService)
        {
            _clientService = clientService ?? throw new ArgumentNullException(nameof(clientService));
        }

        [HttpGet]
        public ActionResult<IEnumerable<ClientResponse>> GetClients()
        {
            try
            {
                var clients = _clientService.GetClients();

                return Ok(clients);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return BadRequest("Ошибка при получении списка пользователей: " + e.Message);
            }
        }

        [HttpGet("{id}")]
        public ActionResult<ClientResponse> GetClientById([FromRoute] long id)
        {
            try
            {
                var client = _clientService.GetClientById(id);

                return Ok(client);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return BadRequest("Ошибка отсутствует пользователь с данным id: " + id + " " + e.Message);
            }
        }

        [HttpPost]
        public async Task<ActionResult> SaveClient(ClientRequest client)
        {
            try
            {
                var clientId = await _clientService.SaveClient(client);

                return Ok();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);

                return BadRequest("Ошибка при добавлении нового пользователя: " + e.Message);
            }
        }
    }
}