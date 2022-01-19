using Projet2_BDD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projet2_BDD.ViewModels
{
    public class MessagesViewModels
    {
        public MessagesViewModels()
        {

        }

        public List<Message> Messages { get; set; }
        public Utilisateur Destinataire { get; set; }
        public Message MailForm { get; set; }
    }
}
