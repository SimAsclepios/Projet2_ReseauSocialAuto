using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Projet2_BDD.Models
{
    public class Message
    {
        public Message()
        {

        }

        public int Id { get; set; }
        //  public string UserName { get; set; }


        public string Msg { get; set; }

        public int EmetteurId { get; set; }
        public int DestinataireId { get; set; }
        public int PublicationId { get; set; } 
        public string PublicationType { get; set; }

       [DisplayFormat(DataFormatString = "{0:dd/MM/yy - HH:mm}", ApplyFormatInEditMode = true)]
        public DateTime DateMsg { get; set; }
    }
}
