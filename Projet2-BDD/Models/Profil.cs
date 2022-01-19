using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Projet2_BDD.Models
{
    public class Profil
    {
        // définir comme clés principale
        public int Id { get; set; }

        public string Description { get; set; }

        //[MaxLength(20)]
        //[Required(ErrorMessage = "Le Nom doit être rempli.")]
        [Display(Name = "Nom")]
        public string Nom { get; set; }

        //[Required(ErrorMessage = "Le Prenom doit être rempli.")]
        [Display(Name = "Prénom")]
        public string Prenom { get; set; }

        //[Required(ErrorMessage = "La Date de naissance doit être rempli.")]
        [Display(Name = "Date de naissance")]
        [DataType(DataType.Date)]
        public string DateDeNaissance { get; set; }

        //[Required(ErrorMessage = "Le Mail doit être rempli.")]
        [Display(Name = "Email")]
        public string Mail { get; set; }

        //[Required(ErrorMessage = "Le Numéros de téléphone doit être rempli.")]
        [Display(Name = "Numéro de téléphone")]
        public int NumeroTelephone { get; set; }
        // Le chemin de l'image
        public string ImageName { get; set; }

    }

       
   }
