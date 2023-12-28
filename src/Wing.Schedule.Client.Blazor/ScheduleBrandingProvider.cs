using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace Wing.Schedule;

[Dependency(ReplaceServices = true)]
public class ScheduleBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "Schedule";
}
