using System;
using System.Threading.Tasks;
using DSharpPlus;

namespace BananaBot
{
    public class Program
    {
        static void Main(string[] args)
        {
            MainAsync().GetAwaiter().GetResult();
        }

        static async Task MainAsync()
        {
            DiscordClient discordClient = new DiscordClient(new DiscordConfiguration()
            {
                Token = BananaConfig.Token,
                TokenType = TokenType.Bot,
                Intents = DiscordIntents.AllUnprivileged
            });
            
            
        }
    }
}