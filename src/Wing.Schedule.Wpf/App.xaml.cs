// This Source Code Form is subject to the terms of the MIT License.
// If a copy of the MIT was not distributed with this file, You can obtain one at https://opensource.org/licenses/MIT.
// Copyright (C) Leszek Pomianowski and WPF UI Contributors.
// All Rights Reserved.

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Serilog;
using Serilog.Events;
using System.Windows.Threading;
using Volo.Abp;
using Wing.Schedule.WPF.Views.Pages;
using Wing.Schedule.WPF.Views.Windows;

namespace Wing.Schedule.WPF
{
    public partial class App : Application
    {
        private IAbpApplicationWithInternalServiceProvider? _abpApplication;

        protected override void OnStartup(StartupEventArgs e)
        {
            Log.Logger = new LoggerConfiguration()
#if DEBUG
           .MinimumLevel.Debug()
#else
            .MinimumLevel.Information()
#endif
           .MinimumLevel.Override("Microsoft", LogEventLevel.Information)
           .Enrich.FromLogContext()
           .WriteTo.Async(c => c.File("Logs/logs.txt"))
           .CreateLogger();

            try
            {
                Log.Information("Starting WPF.");

                _abpApplication = AbpApplicationFactory.Create<ScheduleModule>(options =>
                {
                    options.UseAutofac();
                    options.Services.AddLogging(loggingBuilder => loggingBuilder.AddSerilog(dispose: true));
                });

                _abpApplication.Initialize();

                if (!Current.Windows.OfType<MainWindow>().Any())
                {
                    var navigationWindow = _abpApplication.Services.GetRequiredService<MainWindow>();

                    navigationWindow.Loaded += OnNavigationWindowLoaded;

                    navigationWindow.Show();
                }
            }
            catch (Exception ex)
            {
                Log.Fatal(ex, "Host terminated unexpectedly!");
            }
        }

        private void OnNavigationWindowLoaded(object sender, RoutedEventArgs e)
        {
            if (sender is not MainWindow navigationWindow)
            {
                return;
            }

            navigationWindow.NavigationView.Navigate(typeof(DashboardPage));
        }

        /// <summary>
        /// Occurs when an exception is thrown by an application but not handled.
        /// </summary>
        private void OnDispatcherUnhandledException(object sender, DispatcherUnhandledExceptionEventArgs e)
        {
            // For more info see https://docs.microsoft.com/en-us/dotnet/api/system.windows.application.dispatcherunhandledexception?view=windowsdesktop-6.0
        }
    }
}
