using Dyocense.Documentation.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Dyocense.Documentation
{
    [DependsOn(
        typeof(DocumentationEntityFrameworkCoreTestModule)
        )]
    public class DocumentationDomainTestModule : AbpModule
    {

    }
}