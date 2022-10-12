namespace TailwindTraders.Api.Core.Requests.Handlers;

internal class GetProductRequestHandler : IRequestHandler<GetProductRequest, IActionResult>
{
    private readonly IProductService _productService;

    private readonly IStockService _stockService;

    public GetProductRequestHandler(IProductService productService, IStockService stockService)
    {
        _productService = productService;
        _stockService = stockService;
    }

    public async Task<IActionResult> Handle(GetProductRequest request, CancellationToken cancellationToken)
    {
        var product = await _productService.GetProduct(request.ProductId);

        return new OkObjectResult(product);
    }
}