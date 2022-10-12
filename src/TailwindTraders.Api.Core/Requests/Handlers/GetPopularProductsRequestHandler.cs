namespace TailwindTraders.Api.Core.Requests.Handlers;

internal class GetPopularProductsRequestHandler : IRequestHandler<GetPopularProductsRequest, IActionResult>
{
    /// <remarks>
    ///     @TODO: To be implemented later.
    /// </remarks>
    public async Task<IActionResult> Handle(GetPopularProductsRequest request, CancellationToken cancellationToken)
    {
        var result = new OkResult();

        return await Task.FromResult(result);
    }
}