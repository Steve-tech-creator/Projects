using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace ProductStore.Data;

/* This is used if database provider does't define
 * IProductStoreDbSchemaMigrator implementation.
 */
public class NullProductStoreDbSchemaMigrator : IProductStoreDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
