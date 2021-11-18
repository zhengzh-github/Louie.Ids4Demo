using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Louie.Ids4Demo.Data
{
    /* This is used if database provider does't define
     * IIds4DemoDbSchemaMigrator implementation.
     */
    public class NullIds4DemoDbSchemaMigrator : IIds4DemoDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}