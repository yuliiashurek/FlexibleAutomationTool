using FlexibleAutomationTool.BL.AutomationTasks.TasksFactories;
using FlexibleAutomationTool.BL.AutomationTasks;
using FlexibleAutomationTool.BL.Facade;
using FlexibleAutomationTool.DL.Context;
using FlexibleAutomationTool.DL.Models;

namespace FlexibleAutomationTool.BL.Interpretator
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
