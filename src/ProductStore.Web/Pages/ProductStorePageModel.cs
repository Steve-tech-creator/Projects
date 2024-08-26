using ProductStore.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace ProductStore.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class ProductStorePageModel : AbpPageModel
{
    protected ProductStorePageModel()
    {
        LocalizationResourceType = typeof(ProductStoreResource);
    }
}
