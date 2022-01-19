using Projet2_BDD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projet2_BDD.ViewModels
{
    public class PublicationViewModel
    {
        public CreerDemandeServiceImmaterielViewModel Dmd { get; set; }
        public ProposerServiceMaterielViewModel Mat { get; set; }
        public Evenement_FormationViewModel Event { get; set; }

        // public Location

        
    }
}
