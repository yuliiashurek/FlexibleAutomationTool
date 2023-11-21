
using FlexibleAutomationTool.BL.AutomationTasks.Printers;
using FlexibleAutomationTool.BL.AutomationTasks.Senders;
using FlexibleAutomationTool.DL.Models;

namespace FlexibleAutomationTool.BL.AutomationTasks
{
    public abstract class TaskAbstract
    {
        public string _recipient;

        protected TaskAbstract(string recipient)
        {
            _recipient = recipient;
        }

        public abstract IPrint CreatePrinter(Book book);
        public abstract ISender CreateSender();
    }
}
