using Volo.Abp.Settings;

namespace PhoneBookDemo.Settings
{
    public class PhoneBookDemoSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(PhoneBookDemoSettings.MySetting1));
        }
    }
}
