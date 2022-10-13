namespace TailwindTraders.Api.Core.Services.Interfaces;

internal interface IStockService
{
    Task<StockDto> GetStockAsync(int productId);
}