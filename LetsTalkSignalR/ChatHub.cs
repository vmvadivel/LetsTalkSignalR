﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LetsTalkSignalR.Models;
using Microsoft.AspNetCore.SignalR;

namespace LetsTalkSignalR
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(string name, string text)
        {
            var message = new ChatMessage
            {
                SenderName = name,
                Text = text,
                SentAt = DateTimeOffset.UtcNow
            };

            //Broadcast to all clients
            await Clients.All.SendAsync(
                "ReceiveMessage",
                message.SenderName,
                message.Text,
                message.SentAt
                );
        }
    }
}
