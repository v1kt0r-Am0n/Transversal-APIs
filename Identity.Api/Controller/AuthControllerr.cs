using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
//using MediatR;
//using Identity.Api.Application.Commands;
//using Identity.Api.Application.DTOs;

namespace Identity.Api.Controller
{
    [Route("api/[login]")]
    [ApiController]
    public class AuthControllerr : ControllerBase
    {
        //private readonly IMediator _mediator;

        //public AuthControllerr(IMediator mediator)
        //{
        //    _mediator = mediator;
        //}

        //[HttpPost("login")]
        //public async Task<ActionResult<TokenDto>> Login([FromBody] LoginCommand command)
        //    => await _mediator.Send(command);

        //[HttpPost("register")]
        //public async Task<ActionResult<int>> Register([FromBody] RegisterCommand command)
        //    => await _mediator.Send(command);

        //[HttpPost("refresh-token")]
        //public async Task<ActionResult<TokenDto>> Refresh([FromBody] RefreshTokenCommand command)
        //    => await _mediator.Send(command);
    }
}
