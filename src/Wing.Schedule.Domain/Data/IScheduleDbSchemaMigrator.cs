using System.Threading.Tasks;

namespace Wing.Schedule.Data;

public interface IScheduleDbSchemaMigrator
{
    Task MigrateAsync();
}
