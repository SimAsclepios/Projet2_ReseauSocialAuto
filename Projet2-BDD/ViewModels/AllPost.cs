using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Projet2_BDD.Models;

namespace Projet2_BDD.ViewModels
{
    public class AllPost
    {
        public AllPost()
        {

        }

        public List<DemandeServiceImmateriel> Dmd { get; set; }
        public List<ProposerServiceMateriel> Mat { get; set; }
        public List<Evenement_Formation> Event { get; set; }
        public List<Voiture> Auto { get; set; }
        public List<Covoiturage> Covoit { get; set; }
        public List<BienMateriel> LocMat { get; set; }

        // public Location

        // public DateTime DateTri { get; set; }







        /*
        public static List<string> Type = new List<string>
        {
            "Demande de Service",
            "Vente d'Objets",
            "Evenement / Formation",
            "Location",
        };
        */
        /*
        public enum Type
        {
            Demande_de_Service,
            Vente
        }
        */
    }
}
