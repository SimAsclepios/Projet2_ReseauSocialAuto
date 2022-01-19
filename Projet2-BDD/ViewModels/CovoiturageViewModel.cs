using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projet2_BDD.ViewModels
{
    public class CovoiturageViewModel
    {
        public int Id { get; set; }
        public VoitureViewModel Car { get; set; }
        public string VilleDepart { get; set; }
        public string VilleArrivee { get; set; }
        public string VilleEtape { get; set; }
        public DateTime DateDepart { get; set; }
        public int NbPlace { get; set; }
        public int Prix { get; set; }
        public string Description { get; set; }

    }
}
