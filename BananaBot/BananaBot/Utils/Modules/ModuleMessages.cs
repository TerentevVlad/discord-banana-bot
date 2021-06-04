using DSharpPlus;
using DSharpPlus.EventArgs;

namespace BananaBot.Utils.Modules
{
    public class ModuleMessages
    {
        private DiscordClient _discordClient;
        private string Prefix => "<@!" +_discordClient.CurrentUser.Id.ToString() + ">";
        public ModuleMessages(DiscordClient discordClient)
        {
            _discordClient = discordClient;
        }

        public async void Processing(DiscordClient discordClient, MessageCreateEventArgs eventArgs)
        {
            string message = eventArgs.Message.Content.ToLower();
            
            Debug.Log(eventArgs);
            if (CheckAppeal(message))
            {
                message = RemovePrefix(message);
                if (message.StartsWith("ping"))
                    await eventArgs.Message.RespondAsync("pong!");
            }
        }

        private bool CheckAppeal(string message)
        {
            var words = message.Split(" ");
            if (words.Length > 0)
            {
                if (Prefix.Equals(words[0]))
                    return true;
            }
            return false;
        }

        private string RemovePrefix(string message)
        {
            return message.Replace(Prefix + " ", "");
        } 
    }
}