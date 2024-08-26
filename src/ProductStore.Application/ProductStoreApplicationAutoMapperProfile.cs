using AutoMapper;
using ProductStore.Products;

namespace ProductStore;

public class ProductStoreApplicationAutoMapperProfile : Profile
{
    public ProductStoreApplicationAutoMapperProfile()
    {
        CreateMap<Product,ProductDto>();
        CreateMap<CreateUpdateProductDto, Product>();
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
    }
}
