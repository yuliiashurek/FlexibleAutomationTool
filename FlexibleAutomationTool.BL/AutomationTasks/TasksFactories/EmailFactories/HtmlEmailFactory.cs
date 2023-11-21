using FlexibleAutomationTool.BL.AutomationTasks.Printers;
using FlexibleAutomationTool.BL.AutomationTasks.Senders;
using FlexibleAutomationTool.DL.Models;

namespace FlexibleAutomationTool.BL.AutomationTasks.TasksFactories
{
    public class HtmlEmailFactory : TaskAbstract
    {
        private string _recepient;

        public HtmlEmailFactory(string recipient = "juliysik@gmail.com") : base(recipient)
        {
            _recepient = recipient;
        }

        public override IPrint CreatePrinter(Book book)
        {
            return new HtmlPrinter(book);
        }

        public override ISender CreateSender()
        {
            return new EmailSender(_recepient);
        }
    }
}
