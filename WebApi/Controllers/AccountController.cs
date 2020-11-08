using Business.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IAccountManager _manager;
        public AccountController(
            IAccountManager manager)
        {
            _manager = manager;

        }

        [AllowAnonymous]
        [HttpGet("{email}")]
        public async Task<IActionResult> GetAccount([FromRoute] string email)
        {
            if (!await _manager.ExistsAsync(email))
            {
                return NotFound("Email not found");
            }

            var account = await _manager.GetAccountAsync(email);
            return Ok(account);
        }

        [AllowAnonymous]
        [HttpGet("email/{email}")]
        public async Task<IActionResult> Exists([FromRoute] string email)
        {
            var exists = await _manager.ExistsAsync(email);
            return Ok(exists);
        }

    }
}