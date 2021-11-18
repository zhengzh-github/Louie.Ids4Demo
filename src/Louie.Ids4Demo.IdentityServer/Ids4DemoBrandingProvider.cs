using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace Louie.Ids4Demo
{
    [Dependency(ReplaceServices = true)]
    public class Ids4DemoBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "Ids4Demo";
    }
}
