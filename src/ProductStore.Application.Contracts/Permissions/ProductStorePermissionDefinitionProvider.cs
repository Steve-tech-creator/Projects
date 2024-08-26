using ProductStore.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace ProductStore.Permissions;

public class ProductStorePermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var productStoreGroup = context.AddGroup(ProductStorePermissions.GroupName, L("Permission:ProductStore"));
        var productsPermission = productStoreGroup.AddPermission(ProductStorePermissions.Products.Default, L("Permission:Products"));
        productsPermission.AddChild(ProductStorePermissions.Products.Create, L("Permission:Products.Create"));
        productsPermission.AddChild(ProductStorePermissions.Products.Edit, L("Permission:Products.Edit"));
        productsPermission.AddChild(ProductStorePermissions.Products.Delete, L("Permission:Products.Delete"));
        //Define your own permissions here. Example:
        //myGroup.AddPermission(ProductStorePermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<ProductStoreResource>(name);
    }
}
