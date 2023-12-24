using AutomativeTaskNotificationFacadeService;
using Bus;
using FlexibleAutomationTool.DL.Context;
using FlexibleAutomationTool.DL.Models;
using FlexibleAutomationTool.DL.Repository;
using FlexibleAutomationTool.DL.Services;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using RepositoryCommandService.CommandHandlers;
using RepositoryCommandService.Commands;
using RepositoryCommandService.Interface;

namespace IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection collections)
        {
            collections.AddScoped<IRepository<Book>, BookRepository>();
            collections.AddScoped<IRepository<Rule>, RuleRepository>();
            collections.AddScoped<IRepository<User>, UserRepository>();

            collections.AddScoped<FlexibleAutomationToolContext>();


            collections.AddScoped<IRequestHandler<CreateRuleCommmand, bool>, RuleCommandHandler>();

            collections.AddScoped<ScheduleNotificationFacadeService>();

            collections.AddScoped<IMediatorService, InMemoryBus>();
        }
    }
}