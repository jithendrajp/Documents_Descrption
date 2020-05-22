using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Dyocense.Documentation.EntityFrameworkCore
{
    /* This class is needed for EF Core console commands
     * (like Add-Migration and Update-Database commands) */
    public class DocumentationMigrationsDbContextFactory : IDesignTimeDbContextFactory<DocumentationMigrationsDbContext>
    {
        public DocumentationMigrationsDbContext CreateDbContext(string[] args)
        {
            DocumentationEfCoreEntityExtensionMappings.Configure();

            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<DocumentationMigrationsDbContext>()
                .UseSqlServer(configuration.GetConnectionString("Default"));

            return new DocumentationMigrationsDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}
