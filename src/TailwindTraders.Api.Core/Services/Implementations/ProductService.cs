using Microsoft.EntityFrameworkCore;
using Type = TailwindTraders.Api.Core.Models.Implementations.Dao.Type;

namespace TailwindTraders.Api.Core.Services.Implementations;

internal class ProductService : TailwindTradersServiceBase, IProductService
{
    private readonly ProductsDbContext _productRepository;

    public ProductService(ProductsDbContext productDbContext, IMapper mapper) : base(mapper)
    {
        _productRepository = productDbContext;
    }

    /// <remarks>
    ///     @TODO: Just a placeholder implementation for now. Fix this later.
    /// </remarks>
    public async Task<Product> GetProductAsync(int id, CancellationToken cancellationToken = default)
    {
        return await Task.FromResult(_productRepository.Products.FirstOrDefault(p => p.Id == id));
    }

    /// <remarks>
    ///     @TODO: Just a placeholder implementation for now. Fix this later.
    /// </remarks>
    public async Task<IEnumerable<Product>> GetProductsAsync(int[] brands, int[] typeIds, CancellationToken cancellationToken = default)
    {
        var matchingProducts = brands.Any() || typeIds.Any()
            ? await GetProductsByFilterAsync(brands, typeIds, cancellationToken)
            : await GetAllProductsAsync(cancellationToken);

        matchingProducts.Join(_productRepository.Brands, _productRepository.Types);

        return matchingProducts;
    }

    public async Task<IEnumerable<Brand>> GetBrandsAsync(CancellationToken cancellationToken = default)
    {
        return await _productRepository.Brands.ToListAsync(cancellationToken);
    }

    public async Task<IEnumerable<Type>> GetTypesAsync(CancellationToken cancellationToken = default)
    {
        return await _productRepository.Types.ToListAsync(cancellationToken);
    }

    #region Private Helper Methods

    private async Task<IEnumerable<Product>> GetAllProductsAsync(CancellationToken cancellationToken = default)
    {
        return await _productRepository.Products.ToListAsync(cancellationToken);
    }

    private async Task<IEnumerable<Product>> GetProductsByFilterAsync(int[] brands, int[] typeIds, CancellationToken cancellationToken = default)
    {
        return await _productRepository.Products
            .Where(p => brands.Contains(p.BrandId.GetValueOrDefault()) || typeIds.Contains(p.TypeId.GetValueOrDefault()))
            .ToListAsync(cancellationToken);
    }

    #endregion
}