using System;
using System.Threading.Tasks;
using System.Timers;
using Discord.WebSocket;

namespace WaterBot
{
    static class BotTimer
    {
        static SocketTextChannel _channel;
        static Timer _timer;
        public static void Start(SocketTextChannel channel)
        {
            _channel = channel;

            // Init timer of 3s intervals
            _timer = new Timer(3000);
            // Bind event when interval elapses
            _timer.Elapsed += OnTimer;
            _timer.Enabled = true;
        }

        public static void Stop()
        {
            _timer.Enabled = false;
        }

        public static void OnTimer(Object s, ElapsedEventArgs e)
        {
            _channel.SendMessageAsync("WATER TIME 💦💦💦💦💦💦💦💦💦💦💦");
        }

    }
}