using Microsoft.Azure.Cosmos;

namespace TailwindTraders.Api.Core.Repositories.Implementations;

public class StockRepository : CosmosGenericRepositoryBase<Stock>, IStockRepository
{
    public StockRepository(Database cosmosDatabase) : base(cosmosDatabase, CosmosConstants.StocksContainerName)
    {
    }
}