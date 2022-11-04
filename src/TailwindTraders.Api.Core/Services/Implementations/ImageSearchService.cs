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
            PredictedSearchTerm = searchTerm,
            SearchResults = _productService.GetProducts(searchTerm)
        };

        return result;
    }
}