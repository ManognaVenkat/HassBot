﻿using Discord;
using Discord.Commands;
using System;
using System.Reflection;
using System.Threading.Tasks;

namespace DiscordBotLib
{
    public abstract class BaseModule : ModuleBase<SocketCommandContext>
    {

        protected string MentionedUsers()
        {
            string mentionedUsers = string.Empty;
            foreach (var user in Context.Message.MentionedUsers)
            {
                mentionedUsers += $"{user.Mention} ";
            }

            return mentionedUsers;
        }

        protected string MentionedChannels()
        {
            string mentionedChannels = string.Empty;
            foreach (var channel in Context.Message.MentionedChannels)
            {
                mentionedChannels += $"{channel.Id} ";
            }

            return mentionedChannels.TrimEnd();
        }

        protected async Task DisplayUsage(string usageString)
        {
            Helper LocalHelper = new Helper();
            await LocalHelper.CreateEmbed(
                Context,
                Constants.EMOJI_INFORMATION,
                Constants.USAGE_TITLE,
                usageString
                );
        }
    }
}
