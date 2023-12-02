using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Wing.Schedule.Data;
using Volo.Abp.DependencyInjection;

namespace Wing.Schedule.EntityFrameworkCore;

public class EntityFrameworkCoreScheduleDbSchemaMigrator
    : IScheduleDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreScheduleDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolve the ScheduleDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<ScheduleDbContext>()
            .Database
            .MigrateAsync();
    }
}
