namespace TailwindTraders.Api.Core.Services.Implementations;

internal class ImageSearchService : IImageSearchService
{
    private readonly IImageSearchTermPredictor _predictor;

    private readonly IProductService _productService;

    public ImageSearchService(IImageSearchTermPredictor predictor, IProductService productService)
    {
        _predictor = predictor;
        _productService = productService;
    }

    public async Task<ImageSearchResult> GetProductsAsync(Stream imageStream, CancellationToken cancellationToken = default)
    {
        var searchTerm = await _predictor.PredictSearchTermAsync(imageStream, cancellationToken);

        var result = new ImageSearchResult
        {
            PredictedSearchTerm = searchTerm
        };

        var products = _productService.GetProducts(searchTerm);

        var searchResults = products.Select(p => new ProductDto
        {
            Id = p.Id,
            ImageUrl = p.ImageUrl,
            Name = p.Name,
            Price = p.Price
        });
        result.SearchResults = searchResults;

        return result;
    }
}