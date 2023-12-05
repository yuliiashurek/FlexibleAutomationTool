using FlexibleAutomationTool.DL.Context;
using FlexibleAutomationTool.DL.Repository;
using FlexibleAutomationTool.BL.Services;
using FlexibleAutomationTool.DL.Models;
using FlexibleAutomationTool.BL.IServices;
using FlexibleAutomationTool.BL.AutomationTasks.TasksFactories;
using FlexibleAutomationTool.BL.AutomationTasks;
using System.Net.Mail;
using System.Net.Mime;
using System.Net;
using Telegram.Bot;
using Telegram.Bot.Types;
using FlexibleAutomationTool.BL.Interpretator;

internal class Program
{
    private static async Task Main(string[] args)
    {
        RuleInterpreter rule = new RuleInterpreter(new Context());
        await rule.InterpretRules();
        //Console.ReadKey();
    }
}