using Volo.Abp.Settings;

namespace Louie.Ids4Demo.Settings
{
    public class Ids4DemoSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(Ids4DemoSettings.MySetting1));
        }
    }
}
