using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace Dyocense.Documentation.HttpApi.Client.ConsoleTestApp
{
    [DependsOn(
        typeof(DocumentationHttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class DocumentationConsoleApiClientModule : AbpModule
    {
        
    }
}
