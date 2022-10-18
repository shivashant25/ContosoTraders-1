using Profile = AutoMapper.Profile;

namespace TailwindTraders.Api.Core.Models;

public class AutoMapperProfile : Profile
{
    public AutoMapperProfile()
    {
        #region DAO (storage model) to DTO (API/REST model) conversion

        CreateMap<StockDao, StockDto>()
            .ForMember(dest => dest.ProductId, opt => opt.MapFrom(src => Convert.ToInt32(src.id)));

        // @TODO: Fix this later
        //CreateMap<(Product, IEnumerable<Brand>, IEnumerable<Type>), ProductDto>()
        //    .ForPath(dest => dest, opt => opt.MapFrom(src => MappingHelper.CustomJoin(src.Item1, src.Item2, src.Item3)));

        #endregion

        #region DTO (API/REST model) to DAO (storage model) conversion

        CreateMap<StockDto, StockDao>()
            .ForMember(dest => dest.id, opt => opt.MapFrom(src => src.ProductId.ToString()));

        #endregion
    }
}