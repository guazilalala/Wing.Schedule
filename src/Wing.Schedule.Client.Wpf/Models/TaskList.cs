namespace Wing.Schedule.WPF.Models
{
    /// <summary>
    /// 任务列表
    /// </summary>
    public class TaskList
    {
        public long Id { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// 运行模式
        /// </summary>
        public int RunMode { get; set; }

        /// <summary>
        /// 开始运行时间
        /// </summary>
        public DateTime StartRunTime { get; set; }

        /// <summary>
        /// 上次运行时间
        /// </summary>
        public DateTime? LastRunTime { get; set; }

        /// <summary>
        /// 下次运行时间
        /// </summary>
        public DateTime? NextRunTime { get; set; }

        /// <summary>
        /// 运行次数
        /// </summary>
        public int NumberOfRuns { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        public int Status { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreationTime { get; set; }
    }
}
