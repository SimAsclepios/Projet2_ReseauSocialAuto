using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projet2_BDD.Controllers
{
    // ! Il s'appelle uniquement Pulication sans le "controller" derriere ... Refaire une autre classe avec nom correct si pb !
    public class Publication : Controller
    {

        public IActionResult Publier()
        {
            return View();
        }


        public IActionResult Index()
        {
            return View();
        }


















        /*
        public ActionResult CategorieList()
        {
            //IEnumerable<SelectListItem> items2 = new IEnumerable<SelectListItem>()

                
            List<SelectListItem>  items = new List<SelectListItem>();

            items.Add(new SelectListItem { Text = "Choisissez une Catégorie de Publication", Value = "1", Selected = true });

            items.Add(new SelectListItem { Text = "Demande de Service", Value = "1" });

            items.Add(new SelectListItem { Text = "Vendre un objet", Value = "2" });

            items.Add(new SelectListItem { Text = "Proposer un évenement", Value = "3" });
            //items.Add(new SelectListItem { Text = "Proposer un évenement", Value = "2", Selected = true });
            items.Add(new SelectListItem { Text = "Proposer une Location", Value = "4" });

            IEnumerable<SelectListItem> items2 = items;
            
            ViewBag.ChoisirCategorie = items2;

            return View();
        }
        */
    }
}
