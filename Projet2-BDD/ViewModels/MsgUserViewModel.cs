using Projet2_BDD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projet2_BDD.ViewModels
{
    public class MsgUserViewModel
    {
        public MsgUserViewModel()
        {

        }
        public Message Mail { get; set; }
        public Utilisateur Destinataire { get; set; }
        public string Recherche { get; set; }
    }
}
