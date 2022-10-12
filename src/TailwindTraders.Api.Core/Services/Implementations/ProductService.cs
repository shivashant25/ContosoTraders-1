using Microsoft.EntityFrameworkCore;
using TailwindTraders.Api.Core.Utilities.ExtensionMethods;
using Type = TailwindTraders.Api.Core.Models.Dao.Type;

namespace TailwindTraders.Api.Core.Services.Implementations;

internal class ProductService : IProductService
{
    private readonly ProductsDbContext _productRepository;

    public ProductService(ProductsDbContext productDbContext)
    {
        _productRepository = productDbContext;
    }

    /// <remarks>
    ///     @TODO: Just a placeholder implementation for now. Fix this later.
    /// </remarks>
    public async Task<Product> GetProduct(int id)
    {
        return await Task.FromResult(_productRepository.Products.FirstOrDefault(p => p.Id == id));
    }

    /// <remarks>
    ///     @TODO: Just a placeholder implementation for now. Fix this later.
    /// </remarks>
    public async Task<IEnumerable<Product>> GetProducts(int[] brands, int[] typeIds)
    {
        var matchingProducts = brands.Any() || typeIds.Any()
            ? await GetProductsByFilter(brands, typeIds)
            : await GetAllProducts();

        matchingProducts.Join(_productRepository.Brands, _productRepository.Types);

        return matchingProducts;
    }

    public async Task<IEnumerable<Brand>> GetBrands()
    {
        return await _productRepository.Brands.ToListAsync();
    }

    public async Task<IEnumerable<Type>> GetTypes()
    {
        return await _productRepository.Types.ToListAsync();
    }

    #region Private Helper Methods

    private async Task<IEnumerable<Product>> GetAllProducts()
    {
        return await _productRepository.Products.ToListAsync();
    }

    private async Task<IEnumerable<Product>> GetProductsByFilter(int[] brands, int[] typeIds)
    {
        return await _productRepository.Products
            .Where(p => brands.Contains(p.BrandId.GetValueOrDefault()) || typeIds.Contains(p.TypeId.GetValueOrDefault()))
            .ToListAsync();
    }

    #endregion
}