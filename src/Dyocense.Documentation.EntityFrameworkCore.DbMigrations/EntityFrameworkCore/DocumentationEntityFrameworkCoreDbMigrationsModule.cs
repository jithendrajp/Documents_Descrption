using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace Dyocense.Documentation.EntityFrameworkCore
{
    [DependsOn(
        typeof(DocumentationEntityFrameworkCoreModule)
        )]
    public class DocumentationEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<DocumentationMigrationsDbContext>();
        }
    }
}
