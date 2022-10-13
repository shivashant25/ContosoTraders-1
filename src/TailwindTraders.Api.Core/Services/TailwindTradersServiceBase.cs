using AutoMapper;

namespace TailwindTraders.Api.Core.Services;

internal abstract class TailwindTradersServiceBase
{
    protected readonly IMapper Mapper;

    protected TailwindTradersServiceBase(IMapper mapper)
    {
        Mapper = mapper;
    }
}