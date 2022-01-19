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
    public class VoitureController : Controller
    {
        private IDal dal;
        private readonly IWebHostEnvironment _hostEnvironment;

        public VoitureController(IWebHostEnvironment hostEnvironment)
        {
            this.dal = new dDal();
            this._hostEnvironment = hostEnvironment;
        }

        // Location de voiture //

        public IActionResult CreerVoiture()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreerVoiture(VoitureViewModel car)
        {
            if (ModelState.IsValid)
            {
                string uniquefilename = UploadedFile(car);
                car.UtilisateurId = int.Parse(User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier)?.Value);
                dal.CreerVoiture(car.UtilisateurId, car.Marque, car.Modele, car.Energie, car.Boite, car.Km, car.Annee, car.DispoDebut, car.DispoFin, car.MontantJour, car.MontantKm, car.Description, uniquefilename);
                return Redirect("/Confirmation/Index");
            }
            return View(car);

        }

        private String UploadedFile(VoitureViewModel model)
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

        [HttpPost]
        public IActionResult ModifierVoiture(Voiture car)
        {
            if (!ModelState.IsValid)
                return View(car);

            dal.ModifierVoiture(car.Id, car.UtilisateurId, car.Marque, car.Modele, car.Energie, car.Boite, car.Km, car.Annee, car.DispoDebut, car.DispoFin, car.MontantJour, car.MontantKm, car.Description, car.ImageName);
            return RedirectToAction("/Confirmation/index");
        }

        public IActionResult SupprimerVoiture(int id)
        {
            dal.SupprimerVoiture(id);
            return RedirectToAction("/Voiture/voiture");
        }

        public IActionResult AfficherVoiture()
        {
            try
            {
                List<Voiture> liste = dal.ObtenirVoiture();
                return View(liste);
            }
            catch
            {
                return View(new List<Voiture>());
            }
        }

        public ActionResult Detail(int id)
        {
            Voiture post = dal.ObtenirVoiture(id);
            return View(post);
        }

        // Covoiturage //

        public IActionResult CreerCovoiturage()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreerCovoiturage(CovoiturageViewModel covoit)
        {
            if (ModelState.IsValid)
            {
                string uniquefilename = UploadedFileBis(covoit);
                covoit.Car.Id = int.Parse(User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier)?.Value);
           //     dal.CreerCovoiturage(covoit.Car.Id, covoit.VilleDepart, covoit.VilleArrivee, covoit.VilleEtape, covoit.DateDepart, covoit.NbPlace, covoit.Prix, covoit.Description);
                return Redirect("/Confirmation/Index");
            }
            return View(covoit);
        }

        private String UploadedFileBis(CovoiturageViewModel model)
        {
            string uniqueFileName = null;

            if (model.Car.Image != null)

            {
                var guid = Guid.NewGuid();
                string uploadsFolder = Path.Combine(_hostEnvironment.WebRootPath, "uploads");
                uniqueFileName = guid.ToString() + "_" + model.Car.Image.FileName;

                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    model.Car.Image.CopyTo(fileStream);
                }
            }
            return uniqueFileName;
        }


        [HttpPost]
        public IActionResult ModifierCovoiturage(Covoiturage covoit)
        {
            if (!ModelState.IsValid)
                return View(covoit);

          //  dal.ModifierCovoiturage(covoit.Id, covoit.VilleDepart, covoit.VilleArrivee, covoit.VilleEtape, covoit.DateDepart, covoit.NbPlace, covoit.Prix, covoit.Description);
            return Redirect("/Confirmation/index");
        }

        public IActionResult SupprimerCovoiturage(int id)
        {
            dal.SupprimerCovoiturage(id);
            return Redirect("/Voiture/Covoiturage");
        }

        public IActionResult AfficherCovoiturage()
        {
            try
            {
                List<Covoiturage> liste = dal.ObtenirCovoiturage();
                return View(liste);
            }
            catch
            {
                return View(new List<Covoiturage>());
            }
        }

        public ActionResult DetailBis(int id)
        {
            Covoiturage post = dal.ObtenirCovoiturage(id);
            return View(post);
        }
    }
}
