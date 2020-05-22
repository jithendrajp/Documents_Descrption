using Dyocense.Documentation.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace Dyocense.Documentation.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(DocumentationEntityFrameworkCoreDbMigrationsModule),
        typeof(DocumentationApplicationContractsModule)
        )]
    public class DocumentationDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
