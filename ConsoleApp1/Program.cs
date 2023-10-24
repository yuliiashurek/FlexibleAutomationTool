using FlexibleAutomationTool.BL.AutomationTasks;
using FlexibleAutomationTool.BL.AutomationTasks.Printers;
using FlexibleAutomationTool.BL.AutomationTasks.TasksFactories;

internal class Program
{
    private static void Main(string[] args)
    {
        ITask task = new TorrentFactory();
        task.CreatePrinter();
        task.CreateSender();
        IPrint print = task.CreatePrinter();

    }
}