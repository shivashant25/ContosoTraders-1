using MediatR.Pipeline;

namespace TailwindTraders.Api.Core.Requests.Handlers;

internal class PostImageRequestHandler : IRequestPreProcessor<PostImageRequest>, IRequestHandler<PostImageRequest, IActionResult>
{
    private readonly IImageSearchService _imageSearchService;

    public PostImageRequestHandler(IImageSearchService imageSearchService)
    {
        _imageSearchService = imageSearchService;
    }

    public async Task<IActionResult> Handle(PostImageRequest request, CancellationToken cancellationToken = default)
    {
        var imageSearchResult = await _imageSearchService.GetSimilarProductsAsync(request.File.OpenReadStream(), cancellationToken);

        var searchTags = string.Empty;

        if (!imageSearchResult.SearchResults.Any())
            imageSearchResult.PredictedSearchTags.ToList().ForEach(tag => { searchTags += $"{tag}, "; });

        return imageSearchResult.SearchResults.Any()
            ? new OkObjectResult(imageSearchResult.SearchResults)
            : new ObjectResult($"No matches found for the following tags : {searchTags}") {StatusCode = 404};
    }

    public async Task Process(PostImageRequest request, CancellationToken cancellationToken)
    {
        var validator = new PostImageRequestValidator();

        await validator.ValidateAndThrowAsync(request, cancellationToken);
    }
}