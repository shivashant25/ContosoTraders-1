using System.Reflection;
using Azure.Identity;
using Microsoft.AspNetCore.Builder;
using Microsoft.Azure.Cosmos;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

[assembly: FunctionsStartup(typeof(DependencyInjection))]

namespace TailwindTraders.Api.Core;

public class DependencyInjection : FunctionsStartup
{
    public static void ConfigureServices(HostBuilderContext context, IServiceCollection services)
    {
        ConfigureServicesInternal(services, context.Configuration);
    }


    /// <remarks>
    ///     This is implicitly called by the Azure Functions runtime.
    /// </remarks>
    public override void Configure(IFunctionsHostBuilder builder)
    {
        ConfigureServicesInternal(builder.Services, builder.GetContext().Configuration);
    }


    /// <remarks>
    ///     To be explicitly called from an asp.net core application only
    /// </remarks>
    public static void ConfigureApp()
    {
        var builder = WebApplication.CreateBuilder();

        builder.Configuration.AddAzureKeyVault(
            new Uri(builder.Configuration["KeyVaultEndpoint"]),
            new DefaultAzureCredential());

        ConfigureServicesInternal(builder.Services, builder.Configuration);

        var app = builder.Build();

        ConfigureAspNetCoreMiddleware(app);

        app.Run();
    }


    /// <remarks>
    ///     @TODO: Currently, this method is very 'aspnetcore' specific. Make it more generic (for azure functions) later.
    /// </remarks>
    private static void ConfigureServicesInternal(IServiceCollection services, IConfiguration configuration)
    {
        // injecting auto-mapper
        services.AddAutoMapper(typeof(AutoMapperProfile));

        // inject mediatr
        services.AddMediatR(Assembly.GetExecutingAssembly());

        // inject ef-core dbcontexts (after fetching connection string from azure keyvault).
        var productsDbConnectionString = configuration[KeyVaultConstants.SecretNameProductsDbConnectionString];
        services.AddDbContext<ProductsDbContext>(options => options.UseSqlServer(productsDbConnectionString), ServiceLifetime.Singleton);

        var profilesDbConnectionString = configuration[KeyVaultConstants.SecretNameProfilesDbConnectionString];
        services.AddDbContext<ProfilesDbContext>(options => options.UseSqlServer(profilesDbConnectionString), ServiceLifetime.Singleton);

        // injecting the cosmosdb clients
        var stocksDbConnectionString = configuration[KeyVaultConstants.SecretNameStocksDbConnectionString];
        services.AddSingleton(_ => new CosmosClient(stocksDbConnectionString).GetDatabase(CosmosConstants.DatabaseNameStocks));

        var cartsDbConnectionString = configuration[KeyVaultConstants.SecretNameCartsDbConnectionString];
        services.AddSingleton(_ => new CosmosClient(cartsDbConnectionString).GetDatabase(CosmosConstants.DatabaseNameCarts));

        // inject services
        services
            .AddSingleton<ICartService, CartService>()
            .AddSingleton<IProductService, ProductService>()
            .AddSingleton<IStockService, StockService>();

        // inject repositories
        services
            .AddSingleton<ICartRepository, CartRepository>()
            .AddSingleton<IStockRepository, StockRepository>();

        // @TODO: figure these out later. They are specific to aspnetcore
        services.AddControllers();
        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen();
    }


    /// <remarks>
    ///     Add middleware to the asp.net core request pipeline.
    ///     Note: COR pattern applies, ordering matters.
    /// </remarks>
    private static void ConfigureAspNetCoreMiddleware(WebApplication app)
    {
        app.UseSwagger();
        app.UseSwaggerUI();

        app.UseHttpsRedirection();

        app.UseAuthorization();

        app.MapControllers();
    }
}