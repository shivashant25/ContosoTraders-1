using Type = TailwindTraders.Api.Core.Models.Dao.Type;

namespace TailwindTraders.Api.Core.Utilities.ExtensionMethods;

public static class ProductExtensions
{
    public static void Join(this IEnumerable<Product> products,
        IEnumerable<Brand> brands,
        IEnumerable<Type> types)
    {
        foreach (var product in products)
        {
            product.Brand = brands.FirstOrDefault(brand => brand.Id == product.BrandId);
            product.Type = types.FirstOrDefault(type => type.Id == product.TypeId);
        }
    }
}