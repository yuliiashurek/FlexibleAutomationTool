using RuleInterpretatorService.Intefaces;

namespace RuleInterpretatorService.Services
{
    public class CheckTimerExpressions : IExpressions
    {
        public async Task InterpratAsync(Context context)
        {
            if ((DateTime.Now - context.Time).TotalMinutes > 1)
            {
                AutomativeTaskMailing automativeTaskMailing = new AutomativeTaskMailing(new FlexibleAutomationToolContext(), context.Recipient);
                await automativeTaskMailing.MailingNewBooksAsync();
            }
        }

    }
}
