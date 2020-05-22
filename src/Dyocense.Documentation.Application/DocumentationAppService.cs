using System;
using System.Collections.Generic;
using System.Text;
using Dyocense.Documentation.Localization;
using Volo.Abp.Application.Services;

namespace Dyocense.Documentation
{
    /* Inherit your application services from this class.
     */
    public abstract class DocumentationAppService : ApplicationService
    {
        protected DocumentationAppService()
        {
            LocalizationResource = typeof(DocumentationResource);
        }
    }
}
