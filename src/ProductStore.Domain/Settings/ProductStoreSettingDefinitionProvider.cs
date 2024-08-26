using Volo.Abp.Settings;

namespace ProductStore.Settings;

public class ProductStoreSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(ProductStoreSettings.MySetting1));
    }
}
