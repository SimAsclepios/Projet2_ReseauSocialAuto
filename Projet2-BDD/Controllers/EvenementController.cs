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

namespace Projet_RSA.Controllers
{
    public class EvenementController : Controller
    {
        private IDal dal;
        private readonly IWebHostEnvironment _hostEnvironment;
        public EvenementController(IWebHostEnvironment hostEnvironment)
        {
            this.dal = new dDal();
            this._hostEnvironment = hostEnvironment;
        }
       



        public IActionResult CreerEvenement()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreerEvenement(Evenement_FormationViewModel annonce)
        {

            if (ModelState.IsValid)
            {
                string uniquefilename = UploadedFile(annonce);

                // Pour choper l'Id de l'adhérent qui créer la publication, et la mettre en clé étrangère dans la publication (dmd.UtilisateurId)
                annonce.UtilisateurId = int.Parse(User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier)?.Value);

               
                    dal.CreerEvement(annonce.Titre, annonce.Date, annonce.Lieu, annonce.Description, annonce.NomOrganisateur,  uniquefilename, annonce.UtilisateurId);

                // return RedirectToAction("Index", "ConfirmationController");
                return Redirect("/Confirmation/Index");
            }

            return View(annonce);
        }

       

   
        private String UploadedFile(Evenement_FormationViewModel model)
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
        public IActionResult Evenement()
        {
            int id = int.Parse(User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier)?.Value);
            try
            {

                List<Evenement_Formation> liste = dal.ObtenirListEvenement(id);

                return View(liste);
            }
            catch
            {
                return View(new List<Evenement_Formation>());
            }
        }

        
        public ActionResult Details(int id)

        {

            Evenement_Formation post = dal.ObtenirEvenement(id);



            return View(post);
        }

    }
}