using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProductStore.Products;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ProductStore.Web.Pages.Products
{
	public class CreateModalModel : ProductStorePageModel
    {
        [BindProperty]
        public CreateUpdateProductDto Product { get; set; }

        private readonly IProductAppService _productAppService;

        public CreateModalModel(IProductAppService productAppService)
       {
           _productAppService = productAppService;
        }

        public void OnGet()
        {
            Product = new CreateUpdateProductDto();
        }

        public async Task<IActionResult> OnPostAsync()
        {
           await _productAppService.CreateAsync(Product);
            return NoContent();
        }
    }
}
