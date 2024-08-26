using System;
using Volo.Abp.Application.Dtos;

namespace ProductStore.Products
{
	public class ProductDto : AuditedEntityDto<Guid>
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public float Price { get; set; }

        public int StockQuantity { get; set; }

    }
}

