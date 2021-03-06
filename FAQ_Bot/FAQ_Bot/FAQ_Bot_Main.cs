﻿using System;
using System.Threading.Tasks;
using Discord;
using Discord.WebSocket;

namespace FAQ_Bot
{
    class FAQ_Bot_Main
    {
        static void Main(string[] args)
        
            => new FAQ_Bot_Main().MainAsync().GetAwaiter().GetResult();

        private DiscordSocketClient _client;

            public async Task MainAsync()
            {
            _client = new DiscordSocketClient();

            _client.Log += Log;

            // Remember to keep token private or to read it from an 
            // external source! In this case, we are reading the token 
            // from an environment variable. If you do not know how to set-up
            // environment variables, you may find more information on the 
            // Internet or by using other methods such as reading from 
            // a configuration.
            await _client.LoginAsync(TokenType.Bot,
                "Discord Token");
            await _client.StartAsync();
            _client.MessageReceived += MessageRecieved;
            // Block this task until the program is closed.
            await Task.Delay(-1);
        }

        private async Task MessageRecieved(SocketMessage message)
        {
            if(message.Content == "!FAQ")
            {
                await message.Channel.SendMessageAsync("List goes here");
            }
        }

        private Task Log(LogMessage msg)
        {
            Console.WriteLine(msg.ToString());
            return Task.CompletedTask;
        }
    }
    }

