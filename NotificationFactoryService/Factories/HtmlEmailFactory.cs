using FlexibleAutomationTool.DL.Models;
using NotificationFactoryService.Printers;
using NotificationFactoryService.Senders;


namespace NotificationFactoryService.Factories
{
    public class HtmlEmailFactory : TaskAbstract
    {
        private string _recepient;

        public HtmlEmailFactory(string recipient = "juliysik@gmail.com") : base(recipient)
        {
            _recepient = recipient;
        }

        public override IPrint CreatePrinter(IEnumerable<Book> books)
        {
            return new HtmlPrinter(books);
        }

        public override ISender CreateSender()
        {
            return new EmailSender(_recepient);
        }
    }
}
