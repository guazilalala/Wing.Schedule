using MahApps.Metro.Controls;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;

namespace Wing.Schedule.WPF.ViewModels.Windows
{
    public partial class MainWindowViewModel : BindableBase
    {
        private readonly IRegionManager _regionManager;

        public MainWindowViewModel(IRegionManager regionManager)
        {
            _regionManager = regionManager;
            OpenViewCommand = new DelegateCommand<HamburgerMenuIconItem>(OpenMenu);
        }

        public DelegateCommand<HamburgerMenuIconItem>? OpenViewCommand { get; set; }

        public void OpenMenu(HamburgerMenuIconItem menuItem)
        {
            _regionManager.RequestNavigate(RegionNames.ContentRegion, menuItem.Tag.ToString());
        }
    }
}
