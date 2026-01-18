using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Notification.Api.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotificationsController : ControllerBase
    {
        [HttpPost("send")]
        public async Task<ActionResult<Guid>> Send([FromBody] SendNotificationCommand command)
        => await Mediator.Send(command);

        [HttpGet("status/{id}")]
        public async Task<ActionResult<NotificationStatusDto>> GetStatus(Guid id)
            => await Mediator.Send(new GetNotificationStatusQuery(id));
    }
}
