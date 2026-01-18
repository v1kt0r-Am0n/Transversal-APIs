using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Identity.Api.Controller
{
    [Route("api/[login]")]
    [ApiController]
    public class AuthControllerr : ControllerBase
    {
        [HttpPost("login")]
        public async Task<ActionResult<TokenDto>> Login([FromBody] LoginCommand command)
        => await Mediator.Send(command);

        [HttpPost("register")]
        public async Task<ActionResult<int>> Register([FromBody] RegisterCommand command)
            => await Mediator.Send(command);

        [HttpPost("refresh-token")]
        public async Task<ActionResult<TokenDto>> Refresh([FromBody] RefreshTokenCommand command)
            => await Mediator.Send(command);
    }
}
