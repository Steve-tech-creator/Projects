using System;
using System.ComponentModel.DataAnnotations;
namespace ProductStore.Products
{
	public class CreateUpdateProductDto
	{
        [Required]
        [StringLength(128)]
        public string Name { get; set; } = string.Empty;

        [Required]
        public string Description { get; set; } = string.Empty;

        [Required]
        public float Price { get; set; }

        [Required]
        public int StockQuantity { get; set; }

    }
}

