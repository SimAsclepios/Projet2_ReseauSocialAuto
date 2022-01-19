using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Projet2_BDD.Models
{

    public class DemandeServiceImmateriel
    {

        public DemandeServiceImmateriel()
            {
            Etat = "En Attente";
            }

        public int Id { get; set; }
        public string Titre { get; set; }
        public Categorie Categorie { get; set; }
        public string Description { get; set; }
        public string Budget { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yy - HH:mm}", ApplyFormatInEditMode = true)]
        public DateTime DatePub { get; set; }

        public string ImageName { get; set; }
        public string Prenom { get; set; }

        public string Etat { get; set; }
        // 5 états : - En Attente, - Publié, - Fermé par l'adhérent, - En cours de Réalisation, - Cloturé pour échange.

        public int UtilisateurId { get; set; }
        public virtual Utilisateur Utilisateur { get; set; }

        public bool RechercheTxt(string rech)
        {
            if (Titre.Contains(rech) || Categorie.Equals(rech) || Description.Contains(rech)) return true;
            return false;
        }
    }
    public enum Categorie
    {
        Reparation,
        ChangementPiece,
        Diagnostique,
        Peinture,
        Autres
    }


}
