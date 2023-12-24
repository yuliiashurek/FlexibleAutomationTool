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
                if (tgActiveUserService.isActiveUsers(context.Rule.User.TelegramId).Result)
                {
                    SendTelegramNotificationAsync(context.Books, context.Rule.User.TelegramId.ToString(), out var message);
                    context.Rule.RuleHistory.Executed = true;
                    context.Rule.RuleHistory.DateExecution = DateTime.Now;
                    context.Rule.RuleHistory.Message = message;
                    return true;
                }
            }
            return false;
        }

        private void SendTelegramNotificationAsync(IEnumerable<Book> books, string recepient, out string message)
        {
            TaskAbstract taskFactory = new TextTelegramFactory(recepient);
            var printer = taskFactory.CreatePrinter(books);
            message = printer.Print();
            var sender = taskFactory.CreateSender();
            sender.Send(printer);
        }
    }
}
