using FlexibleAutomationTool.DL.Models;
using NotificationFactoryService;
using NotificationFactoryService.Factories;
using RequestCommunicationService.Services;
using RuleInterpretatorService.Interfaces;

namespace RuleInterpretatorService.Services
{
    public class TelegramExpression : IExpressions
    {
        public async Task<bool> InterpratAsync(Context context)
        {
            if (string.Equals(context.Rule.ConditionMessanger, "telegram") && context.Rule.ConditionDate < DateTime.Now.AddMinutes(3) && context.Rule.ConditionDate >= DateTime.Now.AddMinutes(-1))
            {
                TelegramActiveUsersService tgActiveUserService = new TelegramActiveUsersService();
                if (tgActiveUserService.isActiveUsers().Result)
                {
                    SendTelegramNotificationAsync(context.Books);
                    return true;
                }
            }
            return false;
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
