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
            if (string.Equals(context.Rule.ConditionMessanger, "email") && context.Rule.ConditionDate < DateTime.Now.AddMinutes(3) && context.Rule.ConditionDate >= DateTime.Now.AddMinutes(-1))
            {
                SendEmail(context.Books, out var message);
                context.Rule.RuleHistory.Executed = true;
                context.Rule.RuleHistory.DateExecution = DateTime.Now;
                context.Rule.RuleHistory.Message = message;
                return true;
            }
            return false;
        }

        private void SendEmail(IEnumerable<Book> books, out string message)
        {
            TaskAbstract taskFactory = new HtmlEmailFactory();
            var printer = taskFactory.CreatePrinter(books);
            message = printer.Print();
            var sender = taskFactory.CreateSender();
            sender.Send(printer);
        }

    }
}
