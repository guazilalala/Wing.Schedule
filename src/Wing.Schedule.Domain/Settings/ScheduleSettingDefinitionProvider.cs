using Volo.Abp.Settings;

namespace Wing.Schedule.Settings;

public class ScheduleSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(ScheduleSettings.MySetting1));
    }
}
