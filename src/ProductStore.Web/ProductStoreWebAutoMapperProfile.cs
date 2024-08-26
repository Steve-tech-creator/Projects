using AutoMapper;
using ProductStore.Products;

namespace ProductStore.Web;

public class ProductStoreWebAutoMapperProfile : Profile
{
    public ProductStoreWebAutoMapperProfile()
    {
        CreateMap<ProductDto, CreateUpdateProductDto>();

    }
}