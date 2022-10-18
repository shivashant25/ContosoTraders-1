using Microsoft.Azure.Cosmos;

namespace TailwindTraders.Api.Core.Repositories.Implementations;

public class CartRepository : CosmosGenericRepositoryBase<CartDao>, ICartRepository
{
    public CartRepository(Database cosmosDatabase) : base(cosmosDatabase, CosmosConstants.ContainerNameCarts)
    {
    }
}