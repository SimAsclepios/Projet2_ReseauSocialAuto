using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projet2_BDD.Models
{
    public class Messagerie
    {
        public int Id{ get; set; }
      //  public string UserName { get; set; }
        public string Message { get; set; }
        
        public string UtilisateurId { get; set; }
        public DateTime DateMessage { get; set; }
        public virtual AppUser AppUser { get; set; }
        public string UserName { get; internal set; }
    }
}
