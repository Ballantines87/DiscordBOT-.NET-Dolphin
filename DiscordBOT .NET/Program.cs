using Discord;
using Discord.Net;
using Discord.WebSocket;
using Newtonsoft.Json;
using System;
using System.Threading.Tasks;

namespace DiscordBOT_.NET
{
    public class Program
    {

        private DiscordSocketClient _discordClient;

        public static Task Main(string[] args) => new Program().MainAsync();

        public async Task MainAsync()
        {
            
            System.Environment.SetEnvironmentVariable("Discord", "INSERT BOT TOKEN HERE");
            var _config = new DiscordSocketConfig
            {
                MessageCacheSize = 100,
                //GatewayIntents = GatewayIntents.None
            };

            
            _discordClient = new DiscordSocketClient(_config);
            var loggingService = new LoggingService(_discordClient);
            _discordClient.Log += loggingService.Log;


            await _discordClient.LoginAsync(TokenType.Bot, Environment.GetEnvironmentVariable("Discord"));
            await _discordClient.StartAsync();

            _discordClient.Connected += () =>
            {
                Console.WriteLine("Bot Connected!");
                return Task.CompletedTask;
            };

            _discordClient.Ready += Client_Ready;

            var slashCommandHandlerCommands = new SlashCommandHandlerCommands();
            _discordClient.SlashCommandExecuted += slashCommandHandlerCommands.SlashCommandHandler;


            await Task.Delay(-1);
        }

        

       
        public async Task Client_Ready()
        {
            ulong guildId = 774367867272822785; // to change if implemented in different server


            //1rst command
            var guildCommandManta = new SlashCommandBuilder()
                .WithName("manta-signer")
                .WithDescription("Frequently Asked Questions regarding the Manta Signer");
               
            try
            {
                await _discordClient.Rest.CreateGuildCommand(guildCommandManta.Build(), guildId);
            }
            catch (HttpException exception)
            {
                var json = JsonConvert.SerializeObject(exception.Errors, Formatting.Indented);
                Console.WriteLine(json);
            }


            //2nd command
            var guildCommandDolphinApp = new SlashCommandBuilder()
                .WithName("dolphin-app")
                .WithDescription("Frequently Asked Questions regarding the Dolphin App");

            try
            {
                await _discordClient.Rest.CreateGuildCommand(guildCommandDolphinApp.Build(), guildId);
            }
            catch (HttpException exception)
            {
                var json = JsonConvert.SerializeObject(exception.Errors, Formatting.Indented);
                Console.WriteLine(json);
            }


            //3rd command
            var guildCommandOperatingSystems = new SlashCommandBuilder()
                .WithName("operating-systems")
                .WithDescription("Frequently Asked Questions regarding the Operating Systems");

            try
            {
                await _discordClient.Rest.CreateGuildCommand(guildCommandOperatingSystems.Build(), guildId);
            }
            catch (HttpException exception)
            {
                var json = JsonConvert.SerializeObject(exception.Errors, Formatting.Indented);
                Console.WriteLine(json);
            }

            //4th command
            var guildCommandIncentiveCampaign = new SlashCommandBuilder()
                .WithName("incentive-campaign")
                .WithDescription("Frequently Asked Questions regarding the Incentive Campaign");

            try
            {
                await _discordClient.Rest.CreateGuildCommand(guildCommandIncentiveCampaign.Build(), guildId);
            }
            catch (HttpException exception)
            {
                var json = JsonConvert.SerializeObject(exception.Errors, Formatting.Indented);
                Console.WriteLine(json);
            }

        }

    }
}
