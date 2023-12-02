using System;
using System.Collections.Generic;
using System.Text;
using Wing.Schedule.Localization;
using Volo.Abp.Application.Services;

namespace Wing.Schedule;

/* Inherit your application services from this class.
 */
public abstract class ScheduleAppService : ApplicationService
{
    protected ScheduleAppService()
    {
        LocalizationResource = typeof(ScheduleResource);
    }
}
