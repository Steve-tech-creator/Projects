﻿using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace ProductStore.Products
{
	public class Product : AuditedAggregateRoot<Guid>
	{
        public string Name { get; set; }

        public string Description { get; set; }

        public float Price { get; set; }

        public int StockQuantity { get; set; }
    }
}

