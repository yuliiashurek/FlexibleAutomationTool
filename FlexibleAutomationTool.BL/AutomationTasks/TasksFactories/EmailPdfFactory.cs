using FlexibleAutomationTool.BL.AutomationTasks.Printers;
using FlexibleAutomationTool.BL.AutomationTasks.Senders;
using FlexibleAutomationTool.BL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexibleAutomationTool.BL.AutomationTasks.TasksFactories
{
    public class EmailPdfFactory : ITask
    {
        public IPrint CreatePrinter()
        {
            return new PdfPrinter();
        }

        public ISender CreateSender()
        {
            return new EmailSender();
        }
    }
}
