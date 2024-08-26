using ProductStore.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace ProductStore.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(ProductStoreEntityFrameworkCoreModule),
    typeof(ProductStoreApplicationContractsModule)
    )]
public class ProductStoreDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
    }
}
