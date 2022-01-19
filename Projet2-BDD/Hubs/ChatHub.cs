using Projet2_BDD.Models;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projet2_BDD.Hubs
{
    public class ChatHub:Hub
    {
        public async Task SendMessage(Messagerie message) =>
        
            await Clients.All.SendAsync("ReceiveMessage", message);
        
    }
}
