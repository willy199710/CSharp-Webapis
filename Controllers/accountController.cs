using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration.UserSecrets;
using System.Diagnostics.CodeAnalysis;
using Webapi.Models;

namespace Webapi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class accountController : ControllerBase
    {
        private static List<account> _account = new List<account>();

        [HttpGet("getAccounts")]
        public List<account> getAccounts()
        {
            return _account;
        }

        [HttpGet("{id}")]
        
        public account getById([FromRoute] int id)
        {
            return _account.FirstOrDefault(account => account.id == id);
        }

        [HttpPost("addNewAccount")]
        public IActionResult addNewAccount([FromBody] accountParams parameter)
        {
            _account.Add(new account
            {
                id = _account.Any() ? _account.Max(acc => acc.id) + 1 : 1,
                name = parameter.name,
                description=parameter.description,
            });

            return Ok("successful.");
        }
    }
}
