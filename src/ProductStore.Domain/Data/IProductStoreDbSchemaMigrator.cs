using System.Threading.Tasks;

namespace ProductStore.Data;

public interface IProductStoreDbSchemaMigrator
{
    Task MigrateAsync();
}
