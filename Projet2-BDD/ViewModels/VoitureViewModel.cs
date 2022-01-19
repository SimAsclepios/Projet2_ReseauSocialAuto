using Microsoft.AspNetCore.Http;
using Projet2_BDD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projet2_BDD.ViewModels
{
    public class VoitureViewModel
    {
        public int Id { get; set; }
        public int UtilisateurId { get; set; }
        public virtual Utilisateur Utilisateur { get; set; }
        public Marque Marque { get; set; }
        public string Modele { get; set; }
        public TypeEnergie Energie { get; set; }
        public TypeBoite Boite { get; set; }
        public int Km { get; set; }
        public string Annee { get; set; }
        public DateTime DispoDebut { get; set; }
        public DateTime DispoFin { get; set; }
        public int MontantJour { get; set; }
        public int MontantKm { get; set; }
        public string Description { get; set; }
        public string ImageName { get; set; }
        public IFormFile Image { get; set; }
    }
}
