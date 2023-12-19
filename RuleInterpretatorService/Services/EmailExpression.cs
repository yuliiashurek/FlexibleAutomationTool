using FlexibleAutomationTool.DL.Models;
using NotificationFactoryService;
using NotificationFactoryService.Factories;
using RequestCommunicationService.Services;
using RuleInterpretatorService.Interfaces;

namespace RuleInterpretatorService.Services
{
    public class EmailExpression : IExpressions
    {
        public async Task<bool> InterpratAsync(Context context)
        {
            if (string.Equals(context.WhereToSend, "email") && context.DateAction < DateTime.Now.AddMinutes(3) && context.DateAction >= DateTime.Now.AddMinutes(-1))
            {
                SendEmail(context.Books);
                return true;
            }
            return false;
        }

        private void SendEmail(IEnumerable<Book> books)
        {
            TaskAbstract taskFactory = new HtmlEmailFactory();
            var printer = taskFactory.CreatePrinter(books);
            var sender = taskFactory.CreateSender();
            sender.Send(printer);
        }

    }
}
