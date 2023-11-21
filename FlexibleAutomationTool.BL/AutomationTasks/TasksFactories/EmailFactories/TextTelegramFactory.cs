using FlexibleAutomationTool.BL.AutomationTasks.Printers;
using FlexibleAutomationTool.BL.AutomationTasks.Senders;
using FlexibleAutomationTool.DL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexibleAutomationTool.BL.AutomationTasks.TasksFactories.EmailFactories
{
    public class TextTelegramFactory : TaskAbstract
    {
        private string _recepient;

        public TextTelegramFactory(string recipient = "code") : base(recipient)
        {
            _recepient = recipient;
        }

        public override IPrint CreatePrinter(Book book)
        {
            return new TextPrinter(book);
        }

        public override ISender CreateSender()
        {
            return new TelegramSender(_recepient);
        }
    }
}
