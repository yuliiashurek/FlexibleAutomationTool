using RuleInterpretatorService.Intefaces;

namespace RuleInterpretatorService.Services
{
    public class CheckActiveUsersExpression : IExpressions
    {
        public async Task InterpratAsync(Context context)
        {
            if (context.usersAreActive)
            {
                AutomativeTaskMailing automativeTaskMailing = new AutomativeTaskMailing(new FlexibleAutomationToolContext(), context.Recipient);
                await automativeTaskMailing.MailingNewBooksAsync();
            }
        }
    }
}
