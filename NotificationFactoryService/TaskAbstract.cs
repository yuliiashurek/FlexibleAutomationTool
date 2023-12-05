using FlexibleAutomationTool.DL.Models;
using NotificationFactoryService.Printers;
using NotificationFactoryService.Senders;

namespace NotificationFactoryService
{
    public abstract class TaskAbstract
    {
        public string _recipient;

        protected TaskAbstract(string recipient)
        {
            _recipient = recipient;
        }

        public abstract IPrint CreatePrinter(IEnumerable<Book> book);
        public abstract ISender CreateSender();
    }
}
