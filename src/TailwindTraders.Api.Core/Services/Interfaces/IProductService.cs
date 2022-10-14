using Type = TailwindTraders.Api.Core.Models.Implementations.Dao.Type;

namespace TailwindTraders.Api.Core.Services.Interfaces;

internal interface IProductService
{
    /// <summary>
    /// </summary>
    /// <param name="id"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<Product> GetProductAsync(int id, CancellationToken cancellationToken = default);

    /// <summary>
    /// </summary>
    /// <param name="brands"></param>
    /// <param name="typeIds"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<IEnumerable<ProductDto>> GetProductsAsync(int[] brands, int[] typeIds, CancellationToken cancellationToken = default);

    /// <summary>
    /// </summary>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<IEnumerable<Brand>> GetBrandsAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// </summary>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<IEnumerable<Type>> GetTypesAsync(CancellationToken cancellationToken = default);
}