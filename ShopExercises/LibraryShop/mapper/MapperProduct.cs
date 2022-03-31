using AutoMapper;
using dbshop.businessModel;
using LibraryShop.businessModel;

namespace LibraryShop.mapper;

public static class MapperProduct
{
    private static IMapper mapper
    {
        get
        {
            var config = new MapperConfiguration(cfg =>
                {
                    cfg.CreateMap<ProductHistory, ProductHistoryDTO>().ReverseMap();
                    cfg.CreateMap<Product, ProductDTO>().ReverseMap();
                    cfg.CreateMap<ProductState, ProductStateDTO>().ReverseMap();
                    cfg.CreateMap<TimeRange, TimeRangeDTO>().ReverseMap();
                    cfg.CreateMap<DiscountEnum, DiscountEnumDTO>().ReverseMap();
                });
            return config.CreateMapper();
        }
    }

    public static ProductHistoryDTO toDTO(this ProductHistory p)
    {
        return mapper.Map<ProductHistoryDTO>(p);
    }

    public static ProductHistory toModel(this ProductHistoryDTO p)
    {
        return mapper.Map<ProductHistory>(p);
    }


    public static ProductStateDTO toDTO(this ProductState p)
    {
        return mapper.Map<ProductStateDTO>(p);
    }

    public static ProductState toModel(this ProductStateDTO p)
    {
        return mapper.Map<ProductState>(p);
    }

}
