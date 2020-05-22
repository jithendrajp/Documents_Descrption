using Dyocense.Documentation.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Dyocense.Documentation.Web.Pages
{
    /* Inherit your PageModel classes from this class.
     */
    public abstract class DocumentationPageModel : AbpPageModel
    {
        protected DocumentationPageModel()
        {
            LocalizationResourceType = typeof(DocumentationResource);
        }
    }
}