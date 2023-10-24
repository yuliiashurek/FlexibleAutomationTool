using FlexibleAutomationTool.BL.AutomationTasks.Printers;
using FlexibleAutomationTool.BL.AutomationTasks.Senders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexibleAutomationTool.BL.AutomationTasks.TasksFactories
{
    public class MessageFactory : ITask
    {
        public IPrint CreatePrinter()
        {
            throw new NotImplementedException();
        }

        public ISender CreateSender()
        {
            throw new NotImplementedException();
        }
    }
}
