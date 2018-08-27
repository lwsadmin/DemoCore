using Abp.Authorization;
using Abp.Localization;
using Abp.MultiTenancy;

namespace DemoCore.Authorization
{
    public class DemoCoreAuthorizationProvider : AuthorizationProvider
    {
        public override void SetPermissions(IPermissionDefinitionContext context)
        {
            context.CreatePermission(PermissionNames.Pages_Users, L("Users"));
            context.CreatePermission(PermissionNames.Pages_Roles, L("Roles"));
            context.CreatePermission(PermissionNames.Pages_Tenants, L("Tenants"), multiTenancySides: MultiTenancySides.Host);

            context.CreatePermission(PermissionNames.GoodsCategoryDetele, L("GoodsDelete"));
            context.CreatePermission(PermissionNames.GoodsDelete, L($"GoodsDelete"));
        }

        private static ILocalizableString L(string name)
        {
            return new LocalizableString(name, DemoCoreConsts.LocalizationSourceName);
        }
    }
}
