using FlexibleAutomationTool.DL.Context;
using FlexibleAutomationTool.DL.Repository;
using FlexibleAutomationTool.BL.Services;
using FlexibleAutomationTool.DL.Models;
using FlexibleAutomationTool.BL.IServices;
using FlexibleAutomationTool.BL.AutomationTasks.TasksFactories;
using FlexibleAutomationTool.BL.AutomationTasks;
using FlexibleAutomationTool.BL.Facade;
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

//public class botTest
//{
//    private TelegramBotClient _tgBotClient;
//    private long _chatId;
//    public botTest()
//    {
//        var botToken = "6902881493:AAFNsg53wistwqVRqZPLw1JNNA5nkHqbjoo";
//        _chatId = -4003183963;
//        _tgBotClient = new TelegramBotClient(botToken);
//    }

    //public async Task SendAsync()
    //{
    //    Chat chat = await _tgBotClient.GetChatAsync(456619991);
    //    //var user = await _tgBotClient.GetChatMemberAsync(_chatId, 456619991);
    //    //var status = user.Status;
    //    var a = chat.ActiveUsernames.FirstOrDefault();
    //    await _tgBotClient.SendTextMessageAsync(_chatId, $"User status: {a}");
    //}
//}