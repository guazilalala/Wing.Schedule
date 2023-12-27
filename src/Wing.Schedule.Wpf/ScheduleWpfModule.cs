﻿using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using Wing.Schedule.WPF;
using Wing.Schedule.WPF.Views.Pages;

namespace Wing.Schedule;

public class ScheduleWpfModule : IModule
{
    private readonly IRegionManager _regionManager;

    public ScheduleWpfModule(IRegionManager regionManager)
    {
        _regionManager = regionManager;
    }

    public void OnInitialized(IContainerProvider containerProvider)
    {
        _regionManager.RegisterViewWithRegion(RegionNames.ContentRegion, typeof(TaskListView));
        _regionManager.RegisterViewWithRegion(RegionNames.ContentRegion, typeof(DashboardView));
    }

    public void RegisterTypes(IContainerRegistry containerRegistry)
    {
    }
}
