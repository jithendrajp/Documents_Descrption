﻿using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Dyocense.Documentation.Data
{
    /* This is used if database provider does't define
     * IDocumentationDbSchemaMigrator implementation.
     */
    public class NullDocumentationDbSchemaMigrator : IDocumentationDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}