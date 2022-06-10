using Discord;
using Discord.WebSocket;
using System;
using System.Threading.Tasks;

public class LoggingService
{
    private DiscordSocketClient _client;

    public LoggingService(DiscordSocketClient client)
    {
        _client = client;
    }
    public Task Log(LogMessage msg)
    {
        Console.WriteLine(msg.ToString());
        return Task.CompletedTask;
    }

}
