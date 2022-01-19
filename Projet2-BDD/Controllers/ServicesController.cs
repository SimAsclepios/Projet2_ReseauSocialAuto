using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Projet2_BDD.Dal;
using Projet2_BDD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Hosting;
using Projet2_BDD.ViewModels;
using System.IO;
using System.Security.Claims;
using Projet2_BDD.Controllers;

namespace Projet2_BDD.Controllers
{
    public class ServicesController : Controller
    {
        private IDal dal;
        private readonly IWebHostEnvironment _hostEnvironment;
        public PaymentController Paie = new PaymentController();
        public ServicesController(IWebHostEnvironment hostEnvironment)
        {
            this.dal = new dDal();
            this._hostEnvironment = hostEnvironment;
        }

        
        public IActionResult CreerDemandeService()
        {

            return View();
        }


        public IActionResult AcheterDmd(string montant)
        {
            return Paie.Payer(montant);
        }




        public IActionResult DemandeService()
        {
            return View();
        }
         



        [HttpPost]
        [ValidateAntiForgeryToken]

        public IActionResult CreerDemandeService(CreerDemandeServiceImmaterielViewModel dmd)
        {

            if (ModelState.IsValid)
            {
                string uniquefilename = UploadedFile(dmd);

                // Pour choper l'Id de l'adhérent qui créer la publication, et la mettre en clé étrangère dans la publication (dmd.UtilisateurId)
                dmd.UtilisateurId = int.Parse(User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier)?.Value);
                
                dal.CreerDemande(dmd.Titre, dmd.Categorie, dmd.Description, dmd.Budget, uniquefilename, dmd.UtilisateurId);
                return Redirect("/Confirmation/index");
            }

            //  return ConfirmationController.Confirmation.Index();
            return View(dmd);

        }

        private String UploadedFile(CreerDemandeServiceImmaterielViewModel model)
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

        



        public ActionResult AffichageDemandeService()
        {
            int id = int.Parse(User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier)?.Value);
            try
            {

                List<DemandeServiceImmateriel> liste = dal.ObtenirListServicesImmateriel(id);

                return View(liste);
            }
            catch
            {
                return View(new List<DemandeServiceImmateriel>());
            }

        }

        /*
        [HttpPost]
        public IActionResult ModifierService(DemandeServiceImmateriel dmd)
        {
            if (!ModelState.IsValid)
                return View(dmd);

            dal.ModifierService(dmd.Id, dmd.Titre, dmd.Categorie, dmd.Description, dmd.Budget, dmd.ImageName, dmd.UtilisateurId);
            return RedirectToAction("Index");
        }
        */

        public ActionResult Detail(int id)
        {
            DemandeServiceImmateriel post = dal.ObtenirServiceImmateriel(id);
            return View(post);
        }

    }
}
