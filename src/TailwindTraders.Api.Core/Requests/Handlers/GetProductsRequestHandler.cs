namespace TailwindTraders.Api.Core.Requests.Handlers;

internal class GetProductsRequestHandler : IRequestHandler<GetProductsRequest, IActionResult>
{
    private readonly IProductService _productService;

    public GetProductsRequestHandler(IProductService productService)
    {
        _productService = productService;
    }

    public async Task<IActionResult> Handle(GetProductsRequest request, CancellationToken cancellationToken)
    {
        var brands = await _productService.GetBrands();

        var types = await _productService.GetTypes();

        var typeIds = types
            .Where(t => request.Types.Contains(t.Code))
            .Select(t => t.Id)
            .ToArray();

        var products = await _productService.GetProducts(request.Brands, typeIds);

        if (!products.Any()) return new NoContentResult();

        var aggrResponse = new
        {
            Products = products,
            Brands = brands,
            Types = types
        };

        return new OkObjectResult(aggrResponse);
    }
}