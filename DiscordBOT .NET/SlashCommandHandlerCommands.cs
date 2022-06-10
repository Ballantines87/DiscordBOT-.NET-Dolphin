using Discord;
using Discord.WebSocket;
using System.Threading.Tasks;

namespace DiscordBOT_.NET
{
    public class SlashCommandHandlerCommands
    {
        public async Task SlashCommandHandler(SocketSlashCommand command)
        {
            switch (command.Data.Name)
            {
                case "manta-signer":
                    await HandleMantaSignerCommand(command);
                    break;

                case "dolphin-app":
                    await HandleDolphinAppCommand(command);
                    break;

                case "operating-systems":
                    await HandleOperatingSystemsCommand(command);
                    break;

                case "incentive-campaign":
                    await HandleIncentiveCampaignCommand(command);
                    break;

            }

        }


        private async Task HandleMantaSignerCommand(SocketSlashCommand command)
        {
            var guildUser = (SocketGuildUser)command.User;


            var embedBuiler = new EmbedBuilder()
                .WithAuthor(guildUser.ToString(), guildUser.GetAvatarUrl() ?? guildUser.GetDefaultAvatarUrl())
                .WithTitle($"Manta Signer - Troubleshooting/FAQs")
                .WithDescription(FAQs.DescribingMantaSignerFAQs())
                .WithColor(Color.Green)
                .WithCurrentTimestamp();

            // Now, Let's respond with the embed.

            await command.RespondAsync(embed:embedBuiler.Build(), ephemeral: true);
        }

        private async Task HandleDolphinAppCommand(SocketSlashCommand command)
        {
            var guildUser = (SocketGuildUser)command.User;


            var embedBuiler = new EmbedBuilder()
                .WithAuthor(guildUser.ToString(), guildUser.GetAvatarUrl() ?? guildUser.GetDefaultAvatarUrl())
                .WithTitle($"Dolphin App - Troubleshooting/FAQs")
                .WithDescription(FAQs.DescribingDolphinWebAppFAQs())
                .WithColor(Color.DarkBlue)
                .WithCurrentTimestamp();

            // Now, Let's respond with the embed.
            await command.RespondAsync(embed: embedBuiler.Build(), ephemeral: true);
        }

        private async Task HandleOperatingSystemsCommand(SocketSlashCommand command)
        {

            // Now, Let's respond with the embed.
            await command.RespondAsync($"OPERATING SYSTEMS related questions exposed here...", ephemeral: true);
        }

        private async Task HandleIncentiveCampaignCommand(SocketSlashCommand command)
        {
            var guildUser = (SocketGuildUser)command.User;


            var embedBuiler = new EmbedBuilder()
                .WithAuthor(guildUser.ToString(), guildUser.GetAvatarUrl() ?? guildUser.GetDefaultAvatarUrl())
                .WithTitle($"Dolphin Incentivized Testnet - FAQs")
                .WithDescription(FAQs.DescribingIncentivizedTestnetFAQs())
                .WithColor(Color.Blue)
                .WithCurrentTimestamp();

            // Now, Let's respond with the embed.
            await command.RespondAsync(embed: embedBuiler.Build(), ephemeral: true);

        }
    }
}
