namespace TailwindTraders.Api.Core.Models.Implementations.Dao;

public class CartDao : ICosmosDao<string>
{
    public int Email { get; set; } // partition key

    public string id { get; set; }
}