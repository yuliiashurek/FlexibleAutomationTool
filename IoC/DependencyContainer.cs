using AutomativeTaskNotificationFacadeService;
using FlexibleAutomationTool.DL.Models;
using FlexibleAutomationTool.DL.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection collections)
        {
            collections.AddScoped<IRepository<Book>, BookRepository>();
            collections.AddScoped<IRepository<Rule>, RuleRepository>();
            collections.AddScoped<ScheduleNotificationFacadeService>();
        }
    }
}