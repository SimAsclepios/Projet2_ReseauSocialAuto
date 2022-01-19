using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Projet_RSA.Controllers;
using Projet2_BDD.Dal;
using Projet2_BDD.Models;
using Projet2_BDD.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Projet2_BDD.Controllers
{
    public class AdminController : Controller
    {
        private IDal dal;
        private readonly IWebHostEnvironment _hostEnvironment;
        public static int ContactId { get; set; }
        public AdminController(IWebHostEnvironment hostEnvironment)
        {
            this.dal = new dDal();
            this._hostEnvironment = hostEnvironment;
        }

        public IActionResult Index()
        {
            AdminLayout.EnTete = 0;
            return View();
        }

        public IActionResult ListeProfil()
        {
            List<Utilisateur> user = dal.ObtenirUtilisateur();

            return View(user);
        }

        public IActionResult Publication()
        {
            AllPost viewModel = dal.ObtenirPublicationAttenteAdmin();
            return View(viewModel);
        }

        public IActionResult PublicationLitige()
        {
            AllPost viewModel = dal.ObtenirPublicationLitigeAdmin();
            return View(viewModel);
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



        public ActionResult NonConformeMat(int id)
        {
            ProposerServiceMateriel pub = dal.ObtenirServicesMateriel(id);
            //   pub.Etat = "Refusé";
            dal.RefusMat(pub);
            ContactId = pub.UtilisateurId;
            return View("MotifRefusMessage");
        }

        public ActionResult ConformeMat(int id)
        {
            ProposerServiceMateriel pub = dal.ObtenirServicesMateriel(id);
            //   pub.Etat = "Publié";
            dal.PublieMat(pub);
            dal.PublieMsg(pub.Titre, " vente d'objet ", pub.UtilisateurId);
            return View("Index");
        }

        public ActionResult NonConformeEvent(int id)
        {
            Evenement_Formation pub = dal.ObtenirEvenement(id);
            //   pub.Etat = "Refusé";
            dal.RefusEvent(pub);
            ContactId = pub.UtilisateurId;
            return View("MotifRefusMessage");
        }

        public ActionResult ConformeEvent(int id)
        {
            Evenement_Formation pub = dal.ObtenirEvenement(id);
            //     pub.Etat = "Publié";
            dal.PublieEvent(pub);
            dal.PublieMsg(pub.Titre, " formation/évenement ", pub.UtilisateurId);
            return View("Index");
        }

        public ActionResult NonConformeDmd(int id)
        {
            DemandeServiceImmateriel pub = dal.ObtenirServiceImmateriel(id);
          //  pub.Etat = "Refusé";
            dal.RefusDmd(pub);
            ContactId = pub.UtilisateurId;
            return View("MotifRefusMessage");
        }

        public ActionResult ConformeDmd(int id)
        {
            DemandeServiceImmateriel pub = dal.ObtenirServiceImmateriel(id);
            //   pub.Etat = "Publié";
            dal.PublieDmd(pub);
            dal.PublieMsg(pub.Titre, "demande de service", pub.UtilisateurId);
            return View("Index");
        }

        public IActionResult ListeMessage(int utilisateurId)
        {
            int userId = int.Parse(User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier)?.Value);
            ContactId = utilisateurId;
            MessagesViewModels viewModel = dal.ObtenirMessage(userId, utilisateurId);

            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult ListeMessage(MessagesViewModels msg)
        {
            msg.MailForm.EmetteurId = int.Parse(User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier)?.Value);
            msg.MailForm.DestinataireId = ContactId;
            dal.CreerMsg(msg.MailForm);

            //return View(msg);
            return View(msg.MailForm.DestinataireId);
        }

        public ActionResult MotifRefusMessage()
        {
            MsgUserViewModel msg = new MsgUserViewModel();
            msg.Destinataire = dal.ObtenirUtilisateur(ContactId);
            //msg.Mail = new Message();
            //msg.Mail.DestinataireId = utilisateurId;
            return View(msg);
            // return MessageController.msgControl.EnvoyerMsg(utilisateurId);
        }



        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult MotifRefusMessage(MsgUserViewModel msg)
        {
            msg.Mail.EmetteurId = int.Parse(User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier)?.Value);
            msg.Mail.DestinataireId = ContactId;
            dal.CreerMsg(msg.Mail);

            //return View(msg);
            return Redirect("/Confirmation/MsgConfirmation");
        }


    }
}
