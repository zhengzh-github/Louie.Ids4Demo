using System.Threading.Tasks;

namespace Louie.Ids4Demo.Data
{
    public interface IIds4DemoDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
