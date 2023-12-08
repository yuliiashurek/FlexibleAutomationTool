using FlexibleAutomationTool.DL.Models;
using NotificationFactoryService;
using NotificationFactoryService.Factories;
using RequestCommunicationService.Services;
using RuleInterpretatorService.Interfaces;

namespace RuleInterpretatorService.Services
{
    public class TelegramExpression : IExpressions
    {
        public async Task InterpratAsync(Context context)
        {
            if(string.Equals(context.WhereToSend, "telegram") && context.DateAction < DateTime.Now)
            {
                TelegramActiveUsersService tgActiveUserService = new TelegramActiveUsersService();
                if (tgActiveUserService.isActiveUsers().Result)
                {
                    SendTelegramNotificationAsync(context.Books);
                }
            }
        }

        private void SendTelegramNotificationAsync(IEnumerable<Book> books)
        {
            TaskAbstract taskFactory = new TextTelegramFactory();
            var printer = taskFactory.CreatePrinter(books);
            var sender = taskFactory.CreateSender();
            sender.Send(printer);
        }
    }
}
