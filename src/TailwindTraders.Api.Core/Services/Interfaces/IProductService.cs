using Type = TailwindTraders.Api.Core.Models.Implementations.Dao.Type;

namespace TailwindTraders.Api.Core.Services.Interfaces;

internal interface IProductService
{
    Task<Product> GetProduct(int id);

    Task<IEnumerable<Product>> GetProducts(int[] brands, int[] typeIds);

    Task<IEnumerable<Brand>> GetBrands();

    Task<IEnumerable<Type>> GetTypes();
}