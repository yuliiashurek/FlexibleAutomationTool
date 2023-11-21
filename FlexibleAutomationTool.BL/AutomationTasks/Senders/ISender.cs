using FlexibleAutomationTool.BL.AutomationTasks.Printers;

namespace FlexibleAutomationTool.BL.AutomationTasks.Senders
{
    public interface ISender
    {
        public void Send(IPrint printItem);
    }
}
