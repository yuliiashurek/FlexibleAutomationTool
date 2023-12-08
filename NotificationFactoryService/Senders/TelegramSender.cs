using NotificationFactoryService.Printers;
using Telegram.Bot;

namespace NotificationFactoryService.Senders
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
            if (string.IsNullOrEmpty(printItem.Print()))
            {
                return;
            }
            _tgBotClient.SendTextMessageAsync(_recepient, printItem.Print());
            //return true;
        }
    }
}
