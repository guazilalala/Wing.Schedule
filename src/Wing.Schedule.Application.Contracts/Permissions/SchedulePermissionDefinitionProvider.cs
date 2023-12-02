using Wing.Schedule.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Wing.Schedule.Permissions;

public class SchedulePermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(SchedulePermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(SchedulePermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<ScheduleResource>(name);
    }
}
