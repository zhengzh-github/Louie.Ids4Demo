using Volo.Abp.Modularity;

namespace Louie.Ids4Demo
{
    [DependsOn(
        typeof(Ids4DemoApplicationModule),
        typeof(Ids4DemoDomainTestModule)
        )]
    public class Ids4DemoApplicationTestModule : AbpModule
    {

    }
}