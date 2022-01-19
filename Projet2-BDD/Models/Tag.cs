using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Projet2_BDD.Models
{
    public class Tag
    {
        
            public int ID { get; set; }

            public string Name { get; set; }

            [StringLength(255)]
            [Display(AutoGenerateField = true)]
            [Index(IsUnique = true)] //permet de rendre unique le slug comme ça le tag "Mon Tag" et "mon tag" et "MOn Tag" seront le même :-)
            public string Slug { get; set; }
        //public virtual List<Post> Posts { get; set; }
        
    }
}
