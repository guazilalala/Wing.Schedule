using Autofac.Core;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;
using Wing.Schedule.WPF.ViewModels.Pages;
using Wing.Schedule.WPF.ViewModels.Windows;
using Wing.Schedule.WPF.Views.Pages;
using Wing.Schedule.WPF.Views.Windows;

namespace Wing.Schedule;

[DependsOn(typeof(AbpAutofacModule))]
public class ScheduleModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddSingleton<MainWindow>();

        context.Services.AddSingleton<MainWindowViewModel>();
        context.Services.AddSingleton<INavigationService, NavigationService>();
        context.Services.AddSingleton<ISnackbarService, SnackbarService>();
        context.Services.AddSingleton<IContentDialogService, ContentDialogService>();

        context.Services.AddSingleton<DashboardPage>();
        context.Services.AddSingleton<DashboardViewModel>();

        context.Services.AddSingleton<DataPage>();
        context.Services.AddSingleton<DataViewModel>();

        context.Services.AddSingleton<SettingsPage>();
        context.Services.AddSingleton<SettingsViewModel>();
    }
}
