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
    public async Task<ProductDto> GetProductAsync(int id, CancellationToken cancellationToken = default)
    {
        var productDao = await _productRepository.Products.SingleOrDefaultAsync(product => product.Id == id, cancellationToken);

        if (productDao is null) throw new ProductNotFoundException(id);

        var productDto = CustomMapping(productDao,
            _productRepository.Brands.ToArray(),
            _productRepository.Types.ToArray(),
            _productRepository.Features.ToArray(),
            false);

        return productDto;
    }

    /// <remarks>
    ///     @TODO: Just a placeholder implementation for now. Fix this later.
    /// </remarks>
    public async Task<IEnumerable<ProductDto>> GetProductsAsync(int[] brands, int[] typeIds, CancellationToken cancellationToken = default)
    {
        var responseDaos = brands.Any() || typeIds.Any()
            ? await GetProductsByFilterAsync(brands, typeIds, cancellationToken)
            : await GetAllProductsAsync(cancellationToken);

        var responseDtos = new List<ProductDto>();

        foreach (var responseDao in responseDaos.ToArray())
        {
            var responseDto = CustomMapping(responseDao,
                _productRepository.Brands.ToArray(),
                _productRepository.Types.ToArray(),
                _productRepository.Features.ToArray());

            responseDtos.Add(responseDto);
        }

        return responseDtos;
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


    private ProductDto CustomMapping(Product productDao, IEnumerable<Brand> brands, IEnumerable<Type> types, IEnumerable<Feature> features, bool thumbnailImages = true)
    {
        var imagesEndpoint = Configuration[KeyVaultConstants.SecretNameImagesEndpoint];

        var imagesType = thumbnailImages ? "product-list" : "product-details";

        var productDto = new ProductDto
        {
            Id = productDao.Id,
            Name = productDao.Name,
            Price = productDao.Price,
            ImageUrl = $"{imagesEndpoint}/{imagesType}/{productDao.ImageName}",
            Brand = brands.FirstOrDefault(brand => brand.Id == productDao.BrandId),
            Type = types.FirstOrDefault(type => type.Id == productDao.TypeId),
            Features = features.Where(feature => feature.ProductItemId == productDao.Id)
        };

        return productDto;
    }

    #endregion
}