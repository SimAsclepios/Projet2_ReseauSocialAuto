using Projet2_BDD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Projet2_BDD.ViewModels
{
    public class PaiementChargeViewModel
    {
        public DemandeServiceImmateriel Dmd { get; set; }
        public ProposerServiceMateriel Mat { get; set; }
        public Evenement_Formation Event { get; set; }
        public Voiture Auto { get; set; }
        public Covoiturage Covoit { get; set; }
        public BienMateriel LocMat { get; set; }
        public string Montant { get; set; }
    }
}
