namespace TailwindTraders.Api.Core.Services.Interfaces;

public interface IImageSearchService
{
    Task<ImageSearchResult> GetProductsAsync(Stream imageStream, CancellationToken cancellationToken = default);
}