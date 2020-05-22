using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Localization;
using Dyocense.Documentation.Localization;
using Dyocense.Documentation.MultiTenancy;
using Volo.Abp.TenantManagement.Web.Navigation;
using Volo.Abp.UI.Navigation;

namespace Dyocense.Documentation.Web.Menus
{
    public class DocumentationMenuContributor : IMenuContributor
    {
        public async Task ConfigureMenuAsync(MenuConfigurationContext context)
        {
            if (context.Menu.Name == StandardMenus.Main)
            {
                await ConfigureMainMenuAsync(context);
            }
        }

        private async Task ConfigureMainMenuAsync(MenuConfigurationContext context)
        {
            if (!MultiTenancyConsts.IsEnabled)
            {
                var administration = context.Menu.GetAdministration();
                administration.TryRemoveMenuItem(TenantManagementMenuNames.GroupName);
            }

            var l = context.ServiceProvider.GetRequiredService<IStringLocalizer<DocumentationResource>>();

            context.Menu.Items.Insert(0, new ApplicationMenuItem("Documentation.Home", l["Menu:Home"], "/"));
            context.Menu.Items.Add(new ApplicationMenuItem("Documentation.Docs", l["Menu:Docs"], "/Documents"));
        }
    }
}
