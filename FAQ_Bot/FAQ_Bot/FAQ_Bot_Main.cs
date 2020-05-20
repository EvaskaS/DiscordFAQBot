using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Discord;
using Discord.WebSocket;

namespace FAQ_Bot
{
    class FAQ_Bot_Main
    {
        static void Main(string[] args)
        
            => new FAQ_Bot_Main().MainAsync().GetAwaiter().GetResult();

            List<String> faqList = new List<String>();
        

        private DiscordSocketClient _client;

            public async Task MainAsync()
            {

            //FAQ List
            faqList.Add("Thank you for using FAQBot! Please review this journal:https://www.deviantart.com/artspacious/journal/Feature-Requests-and-FAQ-839151383 . Below you will find questions that have already been asked in this server. ");
            faqList.Add("1.) Is the site ready/open yet? ");
            faqList.Add("1A: ArtSpacious is not open yet. The project was started on April 20th, 2020. We do not yet have an estimated date for when the site will be ready.");
            faqList.Add("2.) Are there any screenshots of the site? ");
            faqList.Add("2A: There are currently no screenshots of the site yet. We have not yet decided on a UI or theme or anything. The main focus currently is functionality and security.");
            faqList.Add("3.) How many themes will there be? Will the theme be easy to read? Do you have an example or mockups of the UI? ");
            faqList.Add("3A: As ArtSpacious is still in the early development stages, we do not have a definitive answer for this yet. We will however be ensuring that our themes and site are accesible to as many people as possible.");
            
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
            if(message.Content == "!FAQ" || message.Content == "!faq")
            {
                foreach(String fq in faqList) { 
                await message.Channel.SendMessageAsync(fq);

                }
            }
        }

        private Task Log(LogMessage msg)
        {
            Console.WriteLine(msg.ToString());
            return Task.CompletedTask;
        }
    }
    }

