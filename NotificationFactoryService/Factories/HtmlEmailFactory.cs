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
