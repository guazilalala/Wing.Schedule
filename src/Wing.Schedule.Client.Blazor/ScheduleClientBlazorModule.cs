using Volo.Abp;
using Volo.Abp.Modularity;

namespace Wing.Schedule.Blazor;

[DependsOn(
    typeof(ScheduleServerModule)
)]
public class ScheduleClientBlazorModule : AbpModule
{

    public override void PreConfigureServices(ServiceConfigurationContext context)
    {
        var hostingEnvironment = context.Services.GetHostingEnvironment();
        var configuration = context.Services.GetConfiguration();
    }

    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        var hostingEnvironment = context.Services.GetHostingEnvironment();
        var configuration = context.Services.GetConfiguration();
    }
}
