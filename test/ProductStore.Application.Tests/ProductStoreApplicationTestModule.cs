using Volo.Abp.Modularity;

namespace ProductStore;

[DependsOn(
    typeof(ProductStoreApplicationModule),
    typeof(ProductStoreDomainTestModule)
    )]
public class ProductStoreApplicationTestModule : AbpModule
{

}
