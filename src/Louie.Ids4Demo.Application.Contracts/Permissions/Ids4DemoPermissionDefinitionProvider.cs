using Louie.Ids4Demo.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Louie.Ids4Demo.Permissions
{
    public class Ids4DemoPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(Ids4DemoPermissions.GroupName);
            //Define your own permissions here. Example:
            //myGroup.AddPermission(Ids4DemoPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<Ids4DemoResource>(name);
        }
    }
}
