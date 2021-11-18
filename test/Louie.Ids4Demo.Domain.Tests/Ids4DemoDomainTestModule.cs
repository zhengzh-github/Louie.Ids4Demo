using Louie.Ids4Demo.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Louie.Ids4Demo
{
    [DependsOn(
        typeof(Ids4DemoEntityFrameworkCoreTestModule)
        )]
    public class Ids4DemoDomainTestModule : AbpModule
    {

    }
}