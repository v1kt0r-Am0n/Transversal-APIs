using Microsoft.AspNetCore.Mvc;
//using MediatR; // Si usas MediatR
//using Notification.Api.Application.Queries; // Ajusta el namespace según donde esté GetNotificationStatusQuery

namespace Notification.Api.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotificationsController : ControllerBase
    {
        //private readonly IMediator _mediator;

        //public NotificationsController(IMediator mediator)
        //{
        //    _mediator = mediator;
        //}

        //[HttpPost("send")]
        //public async Task<ActionResult<Guid>> Send([FromBody] SendNotificationCommand command)
        //    => await _mediator.Send(command);

        //[HttpGet("status/{id}")]
        //public async Task<ActionResult<NotificationStatusDto>> GetStatus(Guid id)
        //    => await _mediator.Send(new GetNotificationStatusQuery(id));
    }
}
