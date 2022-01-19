using Microsoft.AspNetCore.Http;
using Projet2_BDD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projet2_BDD.ViewModels
{
    public class Evenement_FormationViewModel
    {
        public int Id { get; set; }
        public string Titre { get; set; }
        public DateTime Date { get; set; }
        public string Lieu { get; set; }
        public string Description { get; set; }
        public string NomOrganisateur { get; set; }
        public string ImageName { get; set; }
        public IFormFile Image { get; set; }

        public int UtilisateurId { get; set; }

    }
}
