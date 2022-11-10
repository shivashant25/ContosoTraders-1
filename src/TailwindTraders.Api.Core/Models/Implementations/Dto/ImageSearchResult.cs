namespace TailwindTraders.Api.Core.Models.Implementations.Dto;

internal class ImageSearchResult
{
    public IEnumerable<ProductDto> SearchResults { get; set; } = new List<ProductDto>();

    public IEnumerable<string> PredictedSearchTags { get; set; }
}