namespace TailwindTraders.Api.Core.Services.Interfaces;

public interface IImageSearchTermPredictor
{
    Task<string> PredictSearchTermAsync(Stream imageStream, CancellationToken cancellationToken = default);
}