using Type = TailwindTraders.Api.Core.Models.Implementations.Dao.Type;

namespace TailwindTraders.Api.Core.Services.Interfaces;

internal interface IProductService
{
    /// <summary>
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    /// <exception cref="ProductNotFoundException"></exception>
    ProductDto GetProduct(int id);

    /// <summary>
    /// </summary>
    /// <param name="brands"></param>
    /// <param name="typeIds"></param>
    /// <returns></returns>
    IEnumerable<ProductDto> GetProducts(int[] brands, int[] typeIds);

    /// <summary>
    /// </summary>
    /// <returns></returns>
    IEnumerable<Brand> GetBrands();

    /// <summary>
    /// </summary>
    /// <returns></returns>
    IEnumerable<Type> GetTypes();
}