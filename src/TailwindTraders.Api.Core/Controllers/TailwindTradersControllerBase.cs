namespace TailwindTraders.Api.Core.Controllers;

[ApiController]
[Produces("application/json")]
public class TailwindTradersControllerBase : ControllerBase
{
    private readonly IMediator _mediator;

    protected TailwindTradersControllerBase(IMediator mediator)
    {
        _mediator = mediator;
    }

    protected async Task<IActionResult> ProcessHttRequestAsync(IRequest<IActionResult> request)
    {
        return await _mediator.Send(request);
    }
}