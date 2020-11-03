using Business.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly IUserLoginManager _manager;
        public LoginController(
            IUserLoginManager manager)
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
    }
}