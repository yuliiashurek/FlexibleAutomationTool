﻿using Discord;
using Discord.WebSocket;

namespace MacrosService
{
    public class DiscordService
    {
        private DiscordSocketClient _client;
        public DiscordService()
        {
            _client = new DiscordSocketClient();
        }

        public async Task Connect(string token = "MTE4MjczNDkzMDcxNTg2OTIzNA.Gp4wfm.Aa1FrAwV26csxlFayjg6ej4IXTXnc4RKkGNO-8")
        {
            await _client.LoginAsync(TokenType.Bot, token);
            await _client.StartAsync();
        }

        public async Task ChangeStatus(UserStatus status)
        {
            await _client.SetStatusAsync(status);
        }

        private async Task Ready()
        {
            _client.MessageReceived += MessagesReceived;
        }

        public async Task MessagesReceived(SocketMessage arg)
        {
            if (arg.Content.ToLower() == "!status")
            {
                var user = arg.Author as SocketGuildUser;

                if (user?.Presence?.Activities.Count > 0)
                {
                    var lastStatusTime = user.Presence.Activities[0].Timestamps.Start;
                    await arg.Channel.SendMessageAsync($"Last status change: {lastStatusTime}");
                }
                else
                {
                    await arg.Channel.SendMessageAsync("User doesn't have a current status.");
                }
        }
    }
}