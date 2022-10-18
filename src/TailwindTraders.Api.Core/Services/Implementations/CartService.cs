namespace TailwindTraders.Api.Core.Services.Implementations;

internal class CartService : TailwindTradersServiceBase, ICartService
{
    private readonly ICartRepository _cartRepository;

    public CartService(ICartRepository cartRepository, IMapper mapper, IConfiguration configuration) : base(mapper, configuration)
    {
        _cartRepository = cartRepository;
    }
}