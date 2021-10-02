using PhoneBookDemo.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace PhoneBookDemo.Permissions
{
    public class PhoneBookDemoPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(PhoneBookDemoPermissions.GroupName);
            //Define your own permissions here. Example:
            //myGroup.AddPermission(PhoneBookDemoPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<PhoneBookDemoResource>(name);
        }
    }
}
