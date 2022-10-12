namespace TailwindTraders.Api.Core.Services.Interfaces;

internal interface IStockService
{
    Task<Stock> GetStockAsync(int productId);
}