using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Wing.Schedule.Data;

/* This is used if database provider does't define
 * IScheduleDbSchemaMigrator implementation.
 */
public class NullScheduleDbSchemaMigrator : IScheduleDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
