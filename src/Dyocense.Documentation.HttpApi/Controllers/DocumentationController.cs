using Dyocense.Documentation.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Dyocense.Documentation.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class DocumentationController : AbpController
    {
        protected DocumentationController()
        {
            LocalizationResource = typeof(DocumentationResource);
        }
    }
}