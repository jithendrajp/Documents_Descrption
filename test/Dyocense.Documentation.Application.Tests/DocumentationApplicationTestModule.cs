using Volo.Abp.Modularity;

namespace Dyocense.Documentation
{
    [DependsOn(
        typeof(DocumentationApplicationModule),
        typeof(DocumentationDomainTestModule)
        )]
    public class DocumentationApplicationTestModule : AbpModule
    {

    }
}