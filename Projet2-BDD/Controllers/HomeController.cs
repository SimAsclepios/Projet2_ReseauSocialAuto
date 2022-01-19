using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
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
   

    public class HomeController : Controller
    {
        private IDal dal;
        private readonly IWebHostEnvironment _hostEnvironment;
        //    public static int ContactId { get; set; }
        public HomeController(IWebHostEnvironment hostEnvironment)
        {
            this.dal = new dDal();
            this._hostEnvironment = hostEnvironment;
        }

        public ActionResult Index()
        {
            AdminLayout.EnTete = 1;
            return View();
            
        }
        public ActionResult About()
        {
            return View();
        }
        public ActionResult Services()
        {
            return View();
        }
        public ActionResult Contact()
        {
            MsgUserViewModel msg = new MsgUserViewModel();
            // msg.Destinataire = dal.ObtenirUtilisateur(utilisateurId);
            //msg.Mail = new Message();
            //msg.Mail.DestinataireId = utilisateurId;
            //  ContactId = utilisateurId;
            return View(msg);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Contact(MsgUserViewModel msg)
        {
            msg.Mail.EmetteurId = int.Parse(User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier)?.Value);
            msg.Mail.DestinataireId = 1;
            dal.CreerMsg(msg.Mail);

            //return View(msg);
            return Redirect("/Confirmation/MsgConfirmation");
        }
    }
}
