using Microsoft.AspNetCore.Http;
using Projet2_BDD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projet2_BDD.ViewModels
{
    public class ProfilViewModel
    {
        /*
        public ProfilViewModel()
        {

        }
        */

        public Utilisateur Profil { get; set; }
        public IFormFile Image { get; set; }
    }
}
