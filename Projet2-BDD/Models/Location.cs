using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Projet2_BDD.Models
{
    public class Location
    {
        public int Id { get; set; }
        public int UtilisateurId { get; set; }
        public virtual Utilisateur Utilisateur { get; set; }
        public string Titre { get; set; }
        public Rubrique Rubrique { get; set; }

        //[DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}")]
        //public DateTime DispoDebut { get; set; }

        //[DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}")]
        //public DateTime DispoFin { get; set; }
        //public int MontantJour { get; set; }
        //public int MontantKm { get; set; }
        //public string Description { get; set; }
        //public string ImageName { get; set; }
    }

    public enum Rubrique
    {
        Covoiturage,
        Espace,
        [Display(Name = "Matériel")]
        Materiel,
        Voiture
    }
}