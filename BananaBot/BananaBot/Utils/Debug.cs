using System;
using DSharpPlus.EventArgs;

namespace BananaBot.Utils
{
    public static class Debug
    {
        public static void Log(string log)
        {
            Console.WriteLine(log);
        }
        public static void Log(MessageCreateEventArgs eventArgs)
        {
            Log($"[{eventArgs.Message.Timestamp}] " + eventArgs.Author.Username + ":\t" + eventArgs.Message.Content);
        }
        
        public static void Log(object log)
        {
            Log(log.ToString());
        }
    }
}