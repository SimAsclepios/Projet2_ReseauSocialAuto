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

namespace Projet2_BDD.Controllers
{
    public class MessageController : Controller
    {
        private IDal dal;
        private readonly IWebHostEnvironment _hostEnvironment;
        public static MessageController msgControl = new MessageController();
        public static int IdDest { get; set; }
        public MessageController(IWebHostEnvironment hostEnvironment)
        {
            dal = new dDal();
            this._hostEnvironment = hostEnvironment;
        }

        public MessageController()
        {
        }

        public IActionResult Index()
        {
            return View();
        }

        /*
        public ActionResult EnvoyerMsg(int utilisateurId)
        {
            MsgUserViewModel msg = new MsgUserViewModel();
            msg.Destinataire = new Utilisateur();
            //msg.Destinataire = dal.ObtenirUtilisateur(utilisateurId);
            msg.Destinataire = dal.ObtenirUtilisateur(utilisateurId);
            //msg.Mail = new Message();
            //msg.Mail.DestinataireId = utilisateurId;
            IdDest = utilisateurId;
            return View(msg);
        }



        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EnvoyerMsg(MsgUserViewModel msg)
        {
            msg.Mail.EmetteurId = int.Parse(User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier)?.Value);
            msg.Mail.DestinataireId = IdDest;
            Utilisateur destinataire = dal.ObtenirUtilisateur(IdDest);
            dal.CreerMsg(msg.Mail);

            return MsgConfirmation(destinataire);
            //return Redirect("/Confirmation/MsgConfirmation");
        }

        public IActionResult VoirMsg(int idPub)
        {
            return View();
        }

        public ActionResult MsgConfirmation(Utilisateur destinataire)
        {
            return View(destinataire);
        }
        */

    }
}
