using System;
using System.Threading.Tasks;
using ProductStore.Products;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace ProductStore
{
	public class ProductStoreDataSeederContributer:IDataSeedContributor,ITransientDependency
	{
        private readonly IRepository<Product, Guid> _productRepository;

        public ProductStoreDataSeederContributer(IRepository<Product, Guid> productRepository)
        {
            _productRepository = productRepository;
        }
        public async Task SeedAsync(DataSeedContext context)
        {
            if (await _productRepository.GetCountAsync() <= 0)
            {
                await _productRepository.InsertAsync(
                    new Product
                    {
                        Name = "FAN",
                        Description = "crompton fan",
                        Price = 2000,
                        StockQuantity = 2
                    },
                    autoSave: true
                );

                await _productRepository.InsertAsync(
                    new Product
                    {
                        Name = "bulb",
                        Description = "philips bulb",
                        Price = 130,
                        StockQuantity = 3
                    },
                    autoSave: true
                );
            }
        }
    }
}

