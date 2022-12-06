using Abp.Authorization;
using Abp.Localization;
using Abp.MultiTenancy;

namespace LanguageLearning.Authorization
{
    public class LanguageLearningAuthorizationProvider : AuthorizationProvider
    {
        public override void SetPermissions(IPermissionDefinitionContext context)
        {
            context.CreatePermission(PermissionNames.Pages_Users, L("Users"));
            context.CreatePermission(PermissionNames.Pages_Users_Activation, L("UsersActivation"));
            context.CreatePermission(PermissionNames.Pages_Roles, L("Roles"));
            context.CreatePermission(PermissionNames.Pages_Tenants, L("Tenants"), multiTenancySides: MultiTenancySides.Host);

            context.CreatePermission(PermissionNames.Admin, L("Admins"), multiTenancySides: MultiTenancySides.Host);
            context.CreatePermission(PermissionNames.Student, L("Students"), multiTenancySides: MultiTenancySides.Host);
        }

        private static ILocalizableString L(string name)
        {
            return new LocalizableString(name, LanguageLearningConsts.LocalizationSourceName);
        }
    }
}
