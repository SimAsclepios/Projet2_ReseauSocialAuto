using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projet2_BDD.Models
{
    public class AppUser : IdentityUser
    {
        

        public AppUser()
        {
            Messageries = new HashSet<Messagerie>();
        }
       
        public virtual ICollection<Messagerie> Messageries{ get; set;}

    }
}
