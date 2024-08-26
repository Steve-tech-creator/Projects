using ProductStore.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace ProductStore.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class ProductStoreController : AbpControllerBase
{
    protected ProductStoreController()
    {
        LocalizationResource = typeof(ProductStoreResource);
    }
}
