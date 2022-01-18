//https://discordnet.dev/guides/getting_started/first-bot.html
//https://discordnet.dev/guides/getting_started/samples/first-bot/structure.cs

using Discord;
using Discord.WebSocket;

Console.WriteLine("Hello, World!");

DiscordSocketClient _client;

_client = new DiscordSocketClient();

_client.Log += Log;


//  You can assign your bot token to a string, and pass that in to connect.
//  This is, however, insecure, particularly if you plan to have your code hosted in a public repository.
var token = "OTMyOTMxNzAzODQ3MTU3Nzky.YeaKWw.cy2qrOvpqEziCcuLB_MFgFqgQ-s";

// Some alternative options would be to keep your token in an Environment Variable or a standalone file.
// var token = Environment.GetEnvironmentVariable("NameOfYourEnvironmentVariable");
// var token = File.ReadAllText("token.txt");
// var token = JsonConvert.DeserializeObject<AConfigurationClass>(File.ReadAllText("config.json")).Token;

await _client.LoginAsync(TokenType.Bot, token);
await _client.StartAsync();

// Block this task until the program is closed.
await Task.Delay(-1);

Task Log(LogMessage arg)
{
    return Task.FromResult(arg);
}