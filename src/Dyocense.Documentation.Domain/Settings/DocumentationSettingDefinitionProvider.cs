using Volo.Abp.Settings;

namespace Dyocense.Documentation.Settings
{
    public class DocumentationSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(DocumentationSettings.MySetting1));
        }
    }
}
