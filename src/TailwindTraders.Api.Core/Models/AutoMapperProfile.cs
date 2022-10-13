using AutoMapper;

namespace TailwindTraders.Api.Core.Models;

public class AutoMapperProfile : Profile
{
    public AutoMapperProfile()
    {
        #region DAO (storage model) to DTO (API/REST model) conversion

        CreateMap<StockDao, StockDto>()
            .ForMember(dest => dest.ProductId, opt => opt.MapFrom(src => Convert.ToInt32(src.id)));

        #endregion

        #region DTO (API/REST model) to DAO (storage model) conversion

        CreateMap<StockDto, StockDao>()
            .ForMember(dest => dest.id, opt => opt.MapFrom(src => src.ProductId.ToString()));

        #endregion
    }
}