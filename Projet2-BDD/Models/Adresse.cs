using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Projet2_BDD.Models
{
    public class Adresse
    {
        public Adresse()
        {

        }


        //[Required(ErrorMessage = "L'Adresse doit être rempli.")]
        [Display(Name = "Nom de la rue")]
        public string Rue { get; set; }
        public string Ville { get; set; }
        [Display(Name = "Code postal")]
        public string CodePostal { get; set; }

        public string region { get; set; }
        //public string Departement { get; set; }

        public enum Pays
        {
            France,
            Allmagne,
            Belgique,
            Italie


        }
    }
}
