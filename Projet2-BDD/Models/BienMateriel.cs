using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Projet2_BDD.Models
{
    public class BienMateriel
    {
        public BienMateriel()
        {
            Etat = "En Attente";
            DatePub = DateTime.Now;
        }
        public int Id { get; set; }
        public int UtilisateurId { get; set; }
        public virtual Utilisateur Utilisateur { get; set; }
        public string Titre { get; set; }
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}")]
        public DateTime DispoDebut { get; set; }
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}")]
        public DateTime DispoFin { get; set; }
        public int MontantJour { get; set; }
        public string Description { get; set; }
        public string ImageName { get; set; }
        public string Etat { get; set; }
        public DateTime DatePub { get; set; }
    }
}

