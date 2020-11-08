using Business.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Model.Models.Login;
using System.Threading.Tasks;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly ILoginManager _manager;
        public LoginController(
            ILoginManager manager)
        {
            _manager = manager;
        }

        [AllowAnonymous]
        [HttpPost("user")]
        public async Task<IActionResult> Exists([FromBody] AuthenticateModel model)
        {
            var exists = await _manager.ExistsAsync(model.Email, model.Password);
            return Ok(exists);
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> GetLoginUser([FromBody] AuthenticateModel model)
        {
            if (!await _manager.ExistsAsync(model.Email, model.Password))
            {
                return NotFound("user not found");
            }

            var loggedUser = await _manager.GetUserAsync(model.Email, model.Password);
            return Ok(loggedUser);
        }
    }
}