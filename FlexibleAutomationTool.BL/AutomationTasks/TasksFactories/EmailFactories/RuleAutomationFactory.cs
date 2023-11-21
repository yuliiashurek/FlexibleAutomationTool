using FlexibleAutomationTool.BL.AutomationTasks.Printers;
using FlexibleAutomationTool.BL.AutomationTasks.Senders;
using FlexibleAutomationTool.DL.Models;

namespace FlexibleAutomationTool.BL.AutomationTasks.TasksFactories.EmailFactories
{
    public class RuleAutomationFactory : TaskAbstract
    {
        private string _emailRecepient;

        public RuleAutomationFactory(string recipient) : base(recipient)
        {
            _emailRecepient = recipient;
        }

        public override IPrint CreatePrinter(Book book)
        {
            return new PdfPrinter();
        }

        public override ISender CreateSender()
        {
            return new EmailSender(_emailRecepient);
        }
    }
}
