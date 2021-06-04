using System;
using System.Threading.Tasks;
using BananaBot.Utils;
using BananaBot.Utils.Modules;
using DSharpPlus;
using DSharpPlus.VoiceNext;
using Microsoft.Extensions.Logging;
using ;

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
                Intents = DiscordIntents.AllUnprivileged,
            });
            
            ModuleMessages moduleMessages = new ModuleMessages(discordClient);
            DiscordClientExtensions discordClientExtensions = new Dis
            
            
            discordClient.MessageCreated += async (s, e) =>
            {
                moduleMessages.Processing( s, e);
            };
            discordClient.MessageDeleted += async (s, e) =>
            {
                Debug.Log(e);
            };

            await discordClient.ConnectAsync();
            await Task.Delay(-1);
        }
    }
}