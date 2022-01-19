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
    public class ProfilController : Controller
    {
        private IDal dal;
        private readonly IWebHostEnvironment _hostEnvironment;
       // public static int IdDest { get; set; }
       // public static int idPub { get; set; }
        public ProfilController(IWebHostEnvironment hostEnvironment)
        {
            this.dal = new dDal();
            this._hostEnvironment = hostEnvironment;
        }

        public ActionResult AfficherPost()
        {
            int userId = int.Parse(User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier)?.Value);
            
            try
            {
                AllPost nosPosts = dal.VoirNosPosts(userId);
                return View(nosPosts);
            }
            catch
            {
                return View(new AllPost());
            }
        }

        public IActionResult Index()
        {
            ProfilViewModel prof = new ProfilViewModel();
            int id = int.Parse(User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier)?.Value);
            prof.Profil = dal.ObtenirUtilisateur(id);
            return View(prof);
        }

        public IActionResult Modifier()
        {
            ProfilViewModel prof = new ProfilViewModel();
            int id = int.Parse(User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier)?.Value);
            prof.Profil = dal.ObtenirUtilisateur(id);
            return View(prof);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Modifier(ProfilViewModel prof)
        {
            //ProfilViewModel prof0 = new ProfilViewModel();
            int id = int.Parse(User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier)?.Value);
            prof.Profil = dal.ObtenirUtilisateur(id);
            string uniquefilename = UploadedFile(prof);
            prof.Profil.PhotoProfil = uniquefilename;

            dal.ModifierProfil(prof.Profil);
            return RedirectToAction("Index");
        }



        private String UploadedFile(ProfilViewModel prof)
        {
            string uniqueFileName = null;

            if (prof.Image != null)

            {
                var guid = Guid.NewGuid();
                string uploadsFolder = Path.Combine(_hostEnvironment.WebRootPath, "uploads");
                uniqueFileName = guid.ToString() + "_" + prof.Image.FileName;

                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    prof.Image.CopyTo(fileStream);
                }
            }
            return uniqueFileName;
        }

        public ActionResult DetailsMat(int id)
        {
            ProposerServiceMateriel post = dal.ObtenirServicesMateriel(id);
            return View(post);
        }

        public ActionResult DetailsEvent(int id)
        {
            Evenement_Formation post = dal.ObtenirEvenement(id);

            return View(post);
        }

        public ActionResult DetailsDmd(int id)
        {
            DemandeServiceImmateriel post = dal.ObtenirServiceImmateriel(id);
            return View(post);
        }



        public ActionResult SupprimerMat(int id)
        {
            ProposerServiceMateriel pub = dal.ObtenirServicesMateriel(id);
            pub.Etat = "Fermé";
            dal.PublieMat(pub);
            return View("Index");
        }


        public ActionResult SupprimerEvent(int id)
        {
            Evenement_Formation pub = dal.ObtenirEvenement(id);
            pub.Etat = "Fermé";
            dal.PublieEvent(pub);
            return View("Index");
        }


        public ActionResult SupprimerDmd(int id)
        {
            DemandeServiceImmateriel pub = dal.ObtenirServiceImmateriel(id);
            pub.Etat = "Fermé";
            dal.PublieDmd(pub);
            return View("Index");
        }

    }
}
