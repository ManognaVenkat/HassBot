﻿///////////////////////////////////////////////////////////////////////////////
//  AUTHOR          : Suresh Kalavala
//  DATE            : 02/02/2018
//  FILE            : FormatModule.cs
//  DESCRIPTION     : A class that implements ~format command
///////////////////////////////////////////////////////////////////////////////
using Discord.Commands;
using System.Text;
using System.Threading.Tasks;

namespace DiscordBotLib
{
    public class FormatModule : BaseModule {
        [Command("format")]
        public async Task FormatAsync() {
            await FormatCommand();
        }

        [Command("format")]
        public async Task FormatAsync([Remainder]string cmd) {
            await FormatCommand();
        }

        private async Task FormatCommand() {
            StringBuilder sb = new StringBuilder();

            // mention users if any
            string mentionedUsers = base.MentionedUsers();

            if (mentionedUsers.Trim() != string.Empty )
                sb.Append(mentionedUsers + " ");

            sb.Append("To format your text as code, enter three backticks on the first line, press Enter for a new line, paste your code, press Enter again for another new line, and lastly three more backticks. Here's an example:\n\n");
            sb.Append("\\`\\`\\`\n");
            sb.Append("code here\n");
            sb.Append("\\`\\`\\`\n");
            sb.Append("Watch the animated gif here: <https://bit.ly/2GbfRJE>\n");
            sb.Append("**DO NOT** repeat posts. Please edit previously posted message, here is how -> <https://bit.ly/2qOOf1G>");

            await ReplyAsync(sb.ToString(), false, null);
        }
    }
}