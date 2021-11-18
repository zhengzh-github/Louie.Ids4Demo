using Louie.Ids4Demo.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace Louie.Ids4Demo.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(Ids4DemoEntityFrameworkCoreModule),
        typeof(Ids4DemoApplicationContractsModule)
        )]
    public class Ids4DemoDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
