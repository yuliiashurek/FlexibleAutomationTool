using Telegram.Bot;
using Telegram.Bot.Types;

namespace RequestCommunicationService.Services
{
    public class TelegramActiveUsersService
    {
        private TelegramBotClient _tgBotClient;
        private long _chatId;
        public TelegramActiveUsersService()
        {
            var botToken = "6902881493:AAFNsg53wistwqVRqZPLw1JNNA5nkHqbjoo";
            _chatId = -4003183963;
            _tgBotClient = new TelegramBotClient(botToken);
        }

        public async Task<bool> isActiveUsers()
        {
            Chat chat = await _tgBotClient.GetChatAsync(451626433);
            var a = chat.ActiveUsernames.FirstOrDefault();
            if (a != null)
            {
                return true;
            }
            return false;
        }
    }
}
