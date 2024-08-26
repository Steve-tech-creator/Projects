using System;
using System.Collections.Generic;
using System.Text;
using ProductStore.Localization;
using Volo.Abp.Application.Services;

namespace ProductStore;

/* Inherit your application services from this class.
 */
public abstract class ProductAppService : ApplicationService
{
    protected ProductAppService()
    {
        LocalizationResource = typeof(ProductStoreResource);
    }
}
