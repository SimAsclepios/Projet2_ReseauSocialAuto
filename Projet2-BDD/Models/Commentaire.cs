using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Projet2_BDD.Models
{
    public class Commentaire
    {
        // A modifier pour relier à un profil après réalisation d'un service, et non une publication 
        public int ID { get; set; }
        [DataType(DataType.EmailAddress)]
       public string Email { get; set; }
       [StringLength(50)]
       public string Pseudo { get; set; }
       [DataType(DataType.MultilineText)]
       public string Contenu { get; set; }
       public DateTime Publication { get; set; }
       //On crée un lien avec le Post
     //  public Post Parent { get; set; }
        }

    }

