using AutoMapper;

namespace TailwindTraders.Api.Core.Services.Implementations;

internal class StockService : TailwindTradersServiceBase, IStockService
{
    private readonly IStockRepository _stockRepository;

    public StockService(IStockRepository stockRepository, IMapper mapper) : base(mapper)
    {
        _stockRepository = stockRepository;
    }

    public async Task<StockDto> GetStockAsync(int productId, CancellationToken cancellationToken = default)
    {
        var requestDto = new StockDto {ProductId = productId, StockCount = 0};

        var requestDao = Mapper.Map<StockDao>(requestDto);

        var responseDao = await _stockRepository.GetAsync(requestDao.id, requestDao.id, cancellationToken);

        if (responseDao is null) throw new StockNotFoundException(productId);

        var responseDto = Mapper.Map<StockDto>(responseDao);

        return responseDto;
    }
}