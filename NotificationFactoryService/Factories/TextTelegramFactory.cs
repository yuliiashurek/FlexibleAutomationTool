using FlexibleAutomationTool.DL.Models;
using NotificationFactoryService.Printers;
using NotificationFactoryService.Senders;

namespace NotificationFactoryService.Factories
{
    public class TextTelegramFactory : TaskAbstract
    {
        private string _recepient;

        public TextTelegramFactory(string recipient = "code") : base(recipient)
        {
            _recepient = recipient;
        }

        public override IPrint CreatePrinter(IEnumerable<Book> books)
        {
            return new TextPrinter(books);
        }

        public override ISender CreateSender()
        {
            return new TelegramSender(_recepient);
        }
    }
}
