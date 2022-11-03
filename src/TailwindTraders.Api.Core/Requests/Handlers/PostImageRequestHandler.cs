using MediatR.Pipeline;

namespace TailwindTraders.Api.Core.Requests.Handlers;

internal class PostImageRequestHandler : IRequestPreProcessor<PostImageRequest>, IRequestHandler<PostImageRequest, IActionResult>
{
    private readonly IImageSearchService _imageSearchService;

    public PostImageRequestHandler(IImageSearchService imageSearchService)
    {
        _imageSearchService = imageSearchService;
    }

    public async Task<IActionResult> Handle(PostImageRequest request, CancellationToken cancellationToken)
    {
        var products = await _imageSearchService.GetProductsAsync(request.File.OpenReadStream(), cancellationToken);

        return products.SearchResults.Any()
            ? new OkObjectResult(products.SearchResults)
            : new ObjectResult($"No results found matching : {products.PredictedSearchTerm}") {StatusCode = 404};
    }

    public async Task Process(PostImageRequest request, CancellationToken cancellationToken)
    {
        var validator = new PostImageRequestValidator();

        await validator.ValidateAndThrowAsync(request, cancellationToken);
    }
}