using Dyocense.Documentation.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Dyocense.Documentation.Permissions
{
    public class DocumentationPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(DocumentationPermissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(DocumentationPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<DocumentationResource>(name);
        }
    }
}
