using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Louie.Ids4Demo.Data;
using Volo.Abp.DependencyInjection;

namespace Louie.Ids4Demo.EntityFrameworkCore
{
    public class EntityFrameworkCoreIds4DemoDbSchemaMigrator
        : IIds4DemoDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreIds4DemoDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the Ids4DemoDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<Ids4DemoDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}
