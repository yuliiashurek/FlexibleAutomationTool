using FlexibleAutomationTool.BL.AutomationTasks.TasksFactories.EmailFactories;
using FlexibleAutomationTool.BL.AutomationTasks;
using FlexibleAutomationTool.BL.Facade;
using FlexibleAutomationTool.DL.Context;
using FlexibleAutomationTool.DL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexibleAutomationTool.BL.Interpretator
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
