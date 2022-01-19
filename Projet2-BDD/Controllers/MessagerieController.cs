using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Projet2_BDD.Dal;
using Projet2_BDD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Projet2_BDD.ViewModels;

namespace Projet2_BDD.Controllers
{
    public class MessagerieController : Controller
    {
        private IDal dal;
        private readonly IWebHostEnvironment _hostEnvironment;
        public static int ContactId { get; set; }
        public MessagerieController(IWebHostEnvironment hostEnvironment)
        {
            this.dal = new dDal();
            this._hostEnvironment = hostEnvironment;
        }

        public IActionResult Index()
        {
            int userId = int.Parse(User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier)?.Value);
            List <MsgUserViewModel> messagerie = dal.ObtenirMessagerie(userId);
            return View(messagerie);
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

            return Redirect("Index");
          //   return ListeMessage(msg.MailForm.DestinataireId);
        }



    }
}
