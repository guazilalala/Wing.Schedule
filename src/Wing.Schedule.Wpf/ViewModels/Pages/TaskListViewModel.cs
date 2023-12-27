using Prism.Mvvm;
using Prism.Regions;
using System.Collections.ObjectModel;
using Wing.Schedule.WPF.Models;

namespace Wing.Schedule.WPF.ViewModels.Pages
{
    public class TaskListViewModel : BindableBase, INavigationAware
    {
        public TaskListViewModel()
        {
            TaskList = new ObservableCollection<TaskList>();

            //添加100条测试数据
            for (int i = 1; i <= 100; i++)
            {
                TaskList.Add(new()
                {
                    CreationTime = DateTime.Now,
                    Id = i,
                    LastRunTime = DateTime.Now,
                    Name = $"测试任务{i*100}",
                    NextRunTime = DateTime.Now,
                    NumberOfRuns = Random.Shared.Next(1,10000000),
                    RunMode = 1,
                    StartRunTime = DateTime.Now,
                    Status = 1
                });
            }
        }

        public ObservableCollection<TaskList>? TaskList { get; set; }

        public bool IsNavigationTarget(NavigationContext navigationContext)
        {
            return true;
        }

        public void OnNavigatedFrom(NavigationContext navigationContext)
        {
        }

        public void OnNavigatedTo(NavigationContext navigationContext)
        {
        }
    }
}
