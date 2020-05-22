using Volo.Abp.AspNetCore.Mvc.UI.Theme.Shared.Components;
using Volo.Abp.DependencyInjection;

namespace Dyocense.Documentation.Web
{
    [Dependency(ReplaceServices = true)]
    public class DocumentationBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "Documentation";
    }
}
