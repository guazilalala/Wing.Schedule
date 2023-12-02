using Wing.Schedule.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace Wing.Schedule.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(ScheduleEntityFrameworkCoreModule),
    typeof(ScheduleApplicationContractsModule)
    )]
public class ScheduleDbMigratorModule : AbpModule
{
}
