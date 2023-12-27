using Wing.Schedule.Localization;
using Volo.Abp.AspNetCore.Components;

namespace Wing.Schedule;

public abstract class ScheduleComponentBase : AbpComponentBase
{
    protected ScheduleComponentBase()
    {
        LocalizationResource = typeof(ScheduleResource);
    }
}
