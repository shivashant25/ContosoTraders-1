namespace TailwindTraders.Api.Core.Requests.Handlers;

internal class GetStockRequestHandler : IRequestHandler<GetStockRequest, IActionResult>
{
    private readonly IStockService _stockService;

    public GetStockRequestHandler(IStockService stockService)
    {
        _stockService = stockService;
    }

    public async Task<IActionResult> Handle(GetStockRequest request, CancellationToken cancellationToken)
    {
        var stock = await _stockService.GetStockAsync(request.ProductId);

        return new OkObjectResult(stock);
    }
}