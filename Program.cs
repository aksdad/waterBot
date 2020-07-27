using System;
using System.Threading.Tasks;
using Discord;
using Discord.WebSocket;

namespace waterBot
{
    class Program
    {
        private DiscordSocketClient _client;
        private string _token;

        public Program()
        {
            _token = Environment.GetEnvironmentVariable("DISCORD_TOKEN");
        }

        public static void Main(string[] args) => new Program().MainAsync().GetAwaiter().GetResult();

        public async Task MainAsync()
        {
            _client = new DiscordSocketClient();
            _client.Log += Log;
            await _client.LoginAsync(TokenType.Bot, _token);
            await _client.StartAsync();
            _client.MessageReceived += MessageReceived;
            await Task.Delay(-1);
        }

        private Task Log(LogMessage msg)
        {
            Console.WriteLine(msg.ToString());
            return Task.CompletedTask;
        }

        private async Task MessageReceived(SocketMessage msg)
        {
            if (msg.Content == Constants.UserMessage.GimmeWater)
            {
                await msg.Channel.SendMessageAsync(Constants.UserResponses.HereIsYourWater);
            }
        }
    }
}
