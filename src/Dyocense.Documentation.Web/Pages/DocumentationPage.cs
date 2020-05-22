using Microsoft.AspNetCore.Mvc.Localization;
using Microsoft.AspNetCore.Mvc.Razor.Internal;
using Dyocense.Documentation.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Dyocense.Documentation.Web.Pages
{
    /* Inherit your UI Pages from this class. To do that, add this line to your Pages (.cshtml files under the Page folder):
     * @inherits Dyocense.Documentation.Web.Pages.DocumentationPage
     */
    public abstract class DocumentationPage : AbpPage
    {
        [RazorInject]
        public IHtmlLocalizer<DocumentationResource> L { get; set; }
    }
}
