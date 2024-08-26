using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace ProductStore.Web;

[Dependency(ReplaceServices = true)]
public class ProductStoreBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "ProductStore";
}
