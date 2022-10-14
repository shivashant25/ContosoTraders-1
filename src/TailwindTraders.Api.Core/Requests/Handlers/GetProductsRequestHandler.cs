using MediatR.Pipeline;

namespace TailwindTraders.Api.Core.Requests.Handlers;

internal class GetProductsRequestHandler : IRequestPreProcessor<GetProductsRequest>, IRequestHandler<GetProductsRequest, IActionResult>
{
    private readonly IProductService _productService;

    public GetProductsRequestHandler(IProductService productService)
    {
        _productService = productService;
    }

    public async Task<IActionResult> Handle(GetProductsRequest request, CancellationToken cancellationToken)
    {
        var brands = await _productService.GetBrandsAsync(cancellationToken);

        var types = await _productService.GetTypesAsync(cancellationToken);

        var typeIds = types
            .Where(t => request.Types.Contains(t.Code))
            .Select(t => t.Id)
            .ToArray();

        var productDtos = await _productService.GetProductsAsync(request.Brands, typeIds, cancellationToken);

        if (!productDtos.Any()) return new NoContentResult();

        var aggrResponse = new
        {
            Products = productDtos,
            Brands = brands,
            Types = types
        };

        return new OkObjectResult(aggrResponse);
    }

    public async Task Process(GetProductsRequest request, CancellationToken cancellationToken)
    {
        var validator = new GetProductsRequestValidator();

        await validator.ValidateAndThrowAsync(request, cancellationToken);
    }
}