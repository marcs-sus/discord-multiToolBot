using System;
using Discord;

namespace DiscordBot.Utilities
{
    /// <summary>
    /// This class is responsible for logging messages to the console.
    /// </summary>
    public static class Logger
    {
        /// <summary>
        /// Logs a message to the console with a timestamp.
        /// </summary>
        /// <param name="msg"></param>
        /// <returns></returns>
        public static Task Log(LogMessage msg)
        {
            Console.WriteLine($"[{DateTime.Now}] {msg.Severity}: {msg.Message}");
            return Task.CompletedTask;
        }
    }
}