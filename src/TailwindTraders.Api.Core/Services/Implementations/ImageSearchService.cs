namespace TailwindTraders.Api.Core.Services.Implementations;

internal class ImageSearchService : IImageSearchService
{
    private readonly IImageAnalysisService _imageAnalysisService;

    private readonly IProductService _productService;

    public ImageSearchService(IProductService productService, IImageAnalysisService imageAnalysisService)
    {
        _productService = productService;
        _imageAnalysisService = imageAnalysisService;
    }

    public async Task<ImageSearchResult> GetSimilarProductsAsync(Stream imageStream, CancellationToken cancellationToken = default)
    {
        var searchTerms = await _imageAnalysisService.AnalyzeImageAsync(imageStream, cancellationToken);

        var result = new ImageSearchResult();

        var products = new List<ProductDto>();

        foreach (var term in searchTerms)
        {
            var matchingProducts = _productService.GetProducts(term);

            if (matchingProducts.Any())
                products.AddRange(matchingProducts);
        }
        
        result.PredictedSearchTags = searchTerms;

        result.SearchResults = products.Distinct();

        return result;
    }
}