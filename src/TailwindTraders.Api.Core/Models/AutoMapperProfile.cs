using AutoMapper;

namespace TailwindTraders.Api.Core.Models;

public class AutoMapperProfile : Profile
{
    public AutoMapperProfile()
    {
        #region DAO to DTO

        CreateMap<StockDao, StockDto>()
            .ForMember(dest => dest.ProductId, opt => opt.MapFrom(src => Convert.ToInt32(src.id)));

        #endregion

        #region DTO to DAO

        CreateMap<StockDto, StockDao>()
            .ForMember(dest => dest.id, opt => opt.MapFrom(src => src.ProductId.ToString()));

        #endregion
    }
}