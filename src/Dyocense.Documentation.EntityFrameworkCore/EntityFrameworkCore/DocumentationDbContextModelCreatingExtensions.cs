using Microsoft.EntityFrameworkCore;
using Volo.Abp;

namespace Dyocense.Documentation.EntityFrameworkCore
{
    public static class DocumentationDbContextModelCreatingExtensions
    {
        public static void ConfigureDocumentation(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(DocumentationConsts.DbTablePrefix + "YourEntities", DocumentationConsts.DbSchema);

            //    //...
            //});
        }
    }
}