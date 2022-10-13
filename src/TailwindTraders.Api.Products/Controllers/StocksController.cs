namespace TailwindTraders.Api.Products.Controllers;

[Route("v1/[controller]")]
public class StocksController : TailwindTradersControllerBase
{
    public StocksController(IMediator mediator) : base(mediator)
    {
    }

    [HttpGet("{id:int}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<IActionResult> GetStock(int id)
    {
        var request = new GetStockRequest
        {
            ProductId = id
        };

        return await ProcessHttRequestAsync(request);
    }
}