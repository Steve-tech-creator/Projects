using ProductStore.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace ProductStore;

[DependsOn(
    typeof(ProductStoreEntityFrameworkCoreTestModule)
    )]
public class ProductStoreDomainTestModule : AbpModule
{

}
