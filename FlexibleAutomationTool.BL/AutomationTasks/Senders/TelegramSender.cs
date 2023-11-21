using FlexibleAutomationTool.BL.AutomationTasks.Printers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace FlexibleAutomationTool.BL.AutomationTasks.Senders
{
    internal class TelegramSender : ISender
    {
        private long _recepient;// = 451626433;
        private TelegramBotClient _tgBotClient;
        private long _chatId;

        public TelegramSender(string recipient = "451626433") 
        {
            _recepient = 451626433;
            var botToken = "6902881493:AAFNsg53wistwqVRqZPLw1JNNA5nkHqbjoo";
            //_chatId = -4003183963;
            _tgBotClient = new TelegramBotClient(botToken);
        }

        public void Send(IPrint printItem)
        {
            _tgBotClient.SendTextMessageAsync(_recepient, printItem.Print());
            //return true;
        }
    }
}
