namespace TailwindTraders.Api.Products.Controllers;

[Route("v1/[controller]")]
public class ProductsController : TailwindTradersControllerBase
{
    public ProductsController(IMediator mediator) : base(mediator)
    {
    }


    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<IActionResult> GetProducts(
        [FromQuery(Name = "brand")] int[] brands,
        [FromQuery(Name = "type")] string[] types)
    {
        var request = new GetProductsRequest
        {
            Brands = brands,
            Types = types
        };

        return await ProcessHttRequestAsync(request);
    }


    [HttpGet("{id:int}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<IActionResult> GetProduct(int id)
    {
        var request = new GetProductRequest
        {
            ProductId = id
        };

        return await ProcessHttRequestAsync(request);
    }


    [HttpGet("landing")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<IActionResult> GetPopularProducts()
    {
        var request = new GetPopularProductsRequest();

        return await ProcessHttRequestAsync(request);
    }
}