using Microsoft.EntityFrameworkCore;
using Type = TailwindTraders.Api.Core.Models.Implementations.Dao.Type;

namespace TailwindTraders.Api.Core.Services.Implementations;

internal class ProductService : TailwindTradersServiceBase, IProductService
{
    private readonly ProductsDbContext _productRepository;

    public ProductService(ProductsDbContext productDbContext, IMapper mapper, IConfiguration configuration) : base(mapper, configuration)
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
    public async Task<IEnumerable<ProductDto>> GetProductsAsync(int[] brands, int[] typeIds, CancellationToken cancellationToken = default)
    {
        var responseDao = brands.Any() || typeIds.Any()
            ? await GetProductsByFilterAsync(brands, typeIds, cancellationToken)
            : await GetAllProductsAsync(cancellationToken);

        var responseDto = CustomMapping(responseDao, _productRepository.Brands, _productRepository.Types);

        return responseDto;
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
            .Where(p =>
                (brands.Any() ? brands.Contains(p.BrandId.GetValueOrDefault()) : true) &&
                (typeIds.Any() ? typeIds.Contains(p.TypeId.GetValueOrDefault()) : true))
            .ToListAsync(cancellationToken);
    }

    private IEnumerable<ProductDto> CustomMapping(IEnumerable<Product> productDaos, IEnumerable<Brand> brands, IEnumerable<Type> types)
    {
        var productDtos = new List<ProductDto>();

        var imagesEndpoint = Configuration[KeyVaultConstants.SecretNameImagesEndpoint];

        foreach (var dao in productDaos)
        {
            var dto = new ProductDto
            {
                Id = dao.Id,
                Name = dao.Name,
                Price = dao.Price,
                ImageUrl = $"{imagesEndpoint}/product-list/{dao.ImageName}",
                Brand = brands.FirstOrDefault(brand => brand.Id == dao.BrandId),
                Type = types.FirstOrDefault(type => type.Id == dao.TypeId)
            };

            productDtos.Add(dto);
        }

        return productDtos;
    }

    #endregion
}