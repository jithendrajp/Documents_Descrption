using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Dyocense.Documentation.Data;
using Volo.Abp.DependencyInjection;

namespace Dyocense.Documentation.EntityFrameworkCore
{
    public class EntityFrameworkCoreDocumentationDbSchemaMigrator
        : IDocumentationDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreDocumentationDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the DocumentationMigrationsDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<DocumentationMigrationsDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}