using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Projet2_BDD.Dal;
using Projet2_BDD.Models;
using Projet2_BDD.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Projet2_BDD.Controllers
{
    public class LocationController : Controller
    {
        private IDal dal;

        private readonly IWebHostEnvironment _hostEnvironment;
        public PaymentController Paie = new PaymentController();
        public LocationController(IWebHostEnvironment hostEnvironment)

        {
            this.dal = new dDal();
            this._hostEnvironment = hostEnvironment;
        }

        public IActionResult Location()
        {
            return View();
        }

        // Location //

        public IActionResult CreerLocation()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreerLocation(LocationViewModel loc)
        {

            if (ModelState.IsValid)
            {
                loc.UtilisateurId = int.Parse(User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier)?.Value);
                dal.CreerLocation(loc.UtilisateurId, loc.Rubrique);
                return Redirect("/Confirmation/Index");
            }
            return View(loc);
        }



        [HttpPost]
        public IActionResult ModifierLocation(Location loc)
        {
            if (!ModelState.IsValid)
                return View(loc);

            dal.ModifierLocation(loc.Id, loc.UtilisateurId, loc.Titre, loc.Rubrique); ;
            return RedirectToAction("Index");   // vérifier la redirection
        }

        public IActionResult SupprimerLocation(int id)
        {
            dal.SupprimerCovoiturage(id);
            return RedirectToAction("/Voiture/covoiturage");    // vérifier la redirection
        }

        public IActionResult AfficherLocation()
        {
            try
            {
                List<Location> liste = dal.ObtenirLocation();
                return View(liste);
            }
            catch
            {
                return View(new List<Location>());
            }
        }

        public ActionResult Details(int id)

        {
            Location post = dal.ObtenirLocation(id);
            return View(post);
        }

        public IActionResult Acheter(string montant)
        {
            return Paie.Payer(montant);
        }

        // Location Bien Materiel //
        public IActionResult CreerBienMateriel()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreerBienMateriel(BienMaterielViewModel bm)
        {

            if (ModelState.IsValid)
            {
                string uniquefilename = UploadedFile(bm);
                bm.UtilisateurId = int.Parse(User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier)?.Value);
                dal.CreerBienMateriel(bm.UtilisateurId, bm.Titre, bm.DispoDebut, bm.DispoFin, bm.MontantJour, bm.Description, uniquefilename);
                return Redirect("/Confirmation/Index");
            }
            return View(bm);
        }

        [HttpPost]
        public IActionResult ModifierBienMateriel(BienMateriel bm)
        {
            if (!ModelState.IsValid)
                return View(bm);

            dal.ModifierBienMateriel(bm.Id, bm.UtilisateurId, bm.Titre, bm.DispoDebut, bm.DispoFin, bm.MontantJour, bm.Description, bm.ImageName);
            return Redirect("Index");       // vérifier la redirection
        }

        public IActionResult SupprimerBienMateriel(int id)
        {
            dal.SupprimerBienMateriel(id);
            return RedirectToAction("/Voiture/covoiturage");        // vérifier la redirection
        }

        public IActionResult AfficherBienMateriel()
        {
            try
            {
                List<BienMateriel> liste = dal.ObtenirBienMateriel();
                return View(liste);
            }
            catch
            {
                return View(new List<BienMateriel>());
            }
        }

        public ActionResult DetailsBis(int id)

        {
            BienMateriel post = dal.ObtenirBienMateriel(id);
            return View(post);
        }

        private String UploadedFile(BienMaterielViewModel model)
        {
            string uniqueFileName = null;

            if (model.Image != null)

            {
                var guid = Guid.NewGuid();
                string uploadsFolder = Path.Combine(_hostEnvironment.WebRootPath, "uploads");
                uniqueFileName = guid.ToString() + "_" + model.Image.FileName;

                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    model.Image.CopyTo(fileStream);
                }
            }
            return uniqueFileName;
        }


    }
}
