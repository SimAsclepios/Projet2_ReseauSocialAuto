using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Projet2_BDD.Models
{
    public class Covoiturage
    {
        public Covoiturage()
            {
            Etat = "En Attente";
            DatePub = DateTime.Now;
        }

    public int Id { get; set; }
        public int UtilisateurId { get; set; }
        public virtual Utilisateur Utilisateur { get; set; }
      //  public int VoitureId { get; set; }
      //  public virtual Voiture Voiture { get; set; }
        public string VilleDepart { get; set; }
        public string VilleArrivee { get; set; }
        public string VilleEtape { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm}", ApplyFormatInEditMode = true)]
        public DateTime DateDepart { get; set; }
        
        public int Prix { get; set; }
        public string Description { get; set; }
        public string Etat { get; set; }

        public DateTime DatePub { get; set; }

        public string NomVoiture { get; set; }  // voiture non relié (pas le temps)


        public int NbPlace { get; set; }    // Place dispo = Nombre d'adhérent que peut prendre le conducteur
        public int PlacePrise { get; set; }     // Compteur du nombre d'adherent qui achete une place
        public int PlaceRestante { get; set; }
    }
}
