using System;
using ProductStore.Permissions;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
namespace ProductStore.Products
{
	public class ProductAppService:CrudAppService<Product,ProductDto,Guid,PagedAndSortedResultRequestDto,CreateUpdateProductDto>,IProductAppService
	{
        public ProductAppService(IRepository<Product, Guid> repository)
        : base(repository)
        {
            GetPolicyName = ProductStorePermissions.Products.Default;
            GetListPolicyName = ProductStorePermissions.Products.Default;
            CreatePolicyName = ProductStorePermissions.Products.Create;
            UpdatePolicyName = ProductStorePermissions.Products.Edit;
            DeletePolicyName = ProductStorePermissions.Products.Delete;

        }
    }
}

