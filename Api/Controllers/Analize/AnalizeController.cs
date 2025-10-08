using Api.Handlers.Analize;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers.Analize;

[ApiController]
[Route("")]
public class AnalizeController : ControllerBase
{
    private readonly IMediator _mediator;
    public AnalizeController(IMediator mediator) => _mediator = mediator;

    // GET /analize
    [HttpGet("analize")]
    public async Task<IActionResult> Get(CancellationToken ct)
    {
        var result = await _mediator.Send(new AnalizeQuery(), ct);
        return Ok(result);
    }
}