using MahApps.Metro.Controls;
using Prism.Regions;
using System.Diagnostics;

namespace Wing.Schedule.WPF.Views.Windows
{
    public partial class MainWindow
    {
        private readonly IRegionManager _regionManager;

        public MainWindow(IRegionManager regionManager)
        {
            InitializeComponent();
            _regionManager = regionManager;
        }

        private void HamburgerMenuControl_OnItemInvoked(object sender, HamburgerMenuItemInvokedEventArgs e)
        {
            this.HamburgerMenuControl.Content = e.InvokedItem;

            if (!e.IsItemOptions && this.HamburgerMenuControl.IsPaneOpen)
            {
                // You can close the menu if an item was selected
                // this.HamburgerMenuControl.SetCurrentValue(HamburgerMenuControl.IsPaneOpenProperty, false);
            }

            //_regionManager.RequestNavigate(RegionNames.ContentRegion, RegionNames.TaskListRegion);
        }

        private void LaunchWingScheduleOnGitHub(object sender, RoutedEventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "https://github.com/guazilalala/Wing.Schedule",
                UseShellExecute = true
            });
        }
    }
}
