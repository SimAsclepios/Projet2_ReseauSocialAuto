using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Projet2_BDD.Models
{
    public class ProposerServiceMateriel
    {
        public ProposerServiceMateriel()
        {
            Etat = "En Attente";
        }
        public int Id { get; set; }
        public string Titre { get; set; }
        public string Categorie { get; set; }
        public string Prix { get; set; }

        // [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yy - HH:mm}", ApplyFormatInEditMode = true)]
        public DateTime DatePub { get; set; }
        public string Decription { get; set; }
        public string ImageName { get; set; }
        public string Prenom { get; set; }
        public string Etat { get; set; }
        // 6 états : - En Attente, - Publié, - Refusé par l'admin, - Fermé par l'adhérent, - En cours de Réalisation, - Cloturé pour échange.
        public int UtilisateurId { get; set; }
       public virtual Utilisateur Utilisateur { get; set; }


        /*
        public bool RechercheTxt(string rech)
        {
            if (Titre.Contains(rech) || Categorie.Equals(rech) || Decription.Contains(rech)) return true; 
            return false;
        }
        */
    }
}
