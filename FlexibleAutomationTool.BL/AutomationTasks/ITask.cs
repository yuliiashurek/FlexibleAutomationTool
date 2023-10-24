
using FlexibleAutomationTool.BL.AutomationTasks.Printers;
using FlexibleAutomationTool.BL.AutomationTasks.Senders;

namespace FlexibleAutomationTool.BL.AutomationTasks
{
    public interface ITask
    {
        public IPrint CreatePrinter();
        public ISender CreateSender();
    }
}
