using Telegram.Bot;
using Telegram.Bot.Types;

namespace RequestCommunicationService.Services
{
    public class TelegramActiveUsersService
    {
        private TelegramBotClient _tgBotClient;
        public TelegramActiveUsersService()
        {
            var botToken = "6902881493:AAFNsg53wistwqVRqZPLw1JNNA5nkHqbjoo";
            _tgBotClient = new TelegramBotClient(botToken);
        }

        public async Task<bool> isActiveUsers(long tgId)
        {
            //451626433
            Chat chat = await _tgBotClient.GetChatAsync(tgId);
            var a = chat.ActiveUsernames.FirstOrDefault();
            if (a != null)
            {
                return true;
            }
            return false;
        }
    }
}
