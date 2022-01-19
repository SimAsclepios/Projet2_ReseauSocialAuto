using Projet2_BDD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projet2_BDD.ViewModels
{
    public class RechercheMatViewModel
    {
        public string Recherche { get; set; }
        public List <ProposerServiceMateriel> Vue { get; set; }
       // public float PrixMin { get; set; }
       // adresse
        public RechercheMatViewModel()
        {

        }

      //  public static RechercheMatViewModel matRech = new RechercheMatViewModel();
    }
}
