namespace TailwindTraders.Api.Core.Models.Implementations.Dto;

public class ImageSearchResult
{
    public IEnumerable<ProductDto> SearchResults { get; set; } = new List<ProductDto>();
    public string PredictedSearchTerm { get; set; }
}