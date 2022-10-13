using Type = TailwindTraders.Api.Core.Models.Implementations.Dao.Type;

namespace TailwindTraders.Api.Core.Services.Interfaces;

internal interface IProductService
{
    Task<Product> GetProductAsync(int id, CancellationToken cancellationToken = default);

    Task<IEnumerable<Product>> GetProductsAsync(int[] brands, int[] typeIds, CancellationToken cancellationToken = default);

    Task<IEnumerable<Brand>> GetBrandsAsync(CancellationToken cancellationToken = default);

    Task<IEnumerable<Type>> GetTypesAsync(CancellationToken cancellationToken = default);
}