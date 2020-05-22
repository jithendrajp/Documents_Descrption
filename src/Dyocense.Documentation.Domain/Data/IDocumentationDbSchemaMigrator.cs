using System.Threading.Tasks;

namespace Dyocense.Documentation.Data
{
    public interface IDocumentationDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
