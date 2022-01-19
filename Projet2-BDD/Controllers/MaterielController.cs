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
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using Stripe;

namespace Projet2_BDD.Controllers
{
    public class MaterielController : Controller
    {
        private IDal dal;
        private readonly IWebHostEnvironment _hostEnvironment;
        public static int IdDest { get; set; }
        public static int idPub { get; set; }
        public PaymentController Paie; 
        public MaterielController(IWebHostEnvironment hostEnvironment)
        {
            this.dal = new dDal();
            this.Paie = new PaymentController();
            this._hostEnvironment = hostEnvironment;
        }

        
        public IActionResult CreerProposer()
        {

            return View();
        }
        

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreerProposer(ProposerServiceMaterielViewModel annonce)
        {

            if (ModelState.IsValid)
            {
                string uniquefilename = UploadedFile(annonce);

                // Pour choper l'Id de l'adhérent qui créer la publication, et la mettre en clé étrangère dans la publication (dmd.UtilisateurId)
                annonce.UtilisateurId = int.Parse(User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier)?.Value);

                dal.CreerProposer(annonce.Titre, annonce.Categorie, annonce.Prix, annonce.Description, uniquefilename, annonce.UtilisateurId);
                return Redirect("/Confirmation/index");
            }

            // return ConfirmationController.Confirmation.Index();
            return View(annonce);
        }


        private String UploadedFile(ProposerServiceMaterielViewModel model)
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
     

        public ActionResult Recherche()
        {
            try
            {
                int id = int.Parse(User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier)?.Value);
                RechercheMatViewModel listeMat = new RechercheMatViewModel();
                listeMat.Vue = dal.ObtenirListServicesMateriel(id);
                return View(listeMat);
            }
            catch
            {
                return View(new List<ProposerServiceMateriel>());
            }
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Recherche(RechercheMatViewModel rechMat) 
        {
            int id = int.Parse(User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier)?.Value);

            if (rechMat.Recherche != null)
            {
                rechMat.Vue = dal.RechMateriel(rechMat.Recherche, id);
            }
            else rechMat.Vue = dal.ObtenirListServicesMateriel(id);

            return View(rechMat);
        }


        public IActionResult AcheterMat(string montant)
        {
            return Paie.Payer(montant);
        }

        public ActionResult Details(int id)
        {
            ProposerServiceMateriel post = dal.ObtenirServicesMateriel(id);
            return View(post);
        }



        /*
        public ActionResult EnvoyerMsg(int utilisateurId)
        {
            return MessageController.msgControl.EnvoyerMsg(utilisateurId);
        }
        */
        
        public ActionResult EnvoyerMsg(int utilisateurId)
        {
            MsgUserViewModel msg = new MsgUserViewModel();
            msg.Destinataire = dal.ObtenirUtilisateur(utilisateurId);
            //msg.Mail = new Message();
            //msg.Mail.DestinataireId = utilisateurId;
            IdDest = utilisateurId;
            return View(msg);
           // return MessageController.msgControl.EnvoyerMsg(utilisateurId);
        }



        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EnvoyerMsg(MsgUserViewModel msg)
        {
            msg.Mail.EmetteurId = int.Parse(User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier)?.Value);
            msg.Mail.DestinataireId = IdDest;
            dal.CreerMsg(msg.Mail);

            //return View(msg);
               return Redirect("/Confirmation/MsgConfirmation");
        }




        public IActionResult Modifier(int id)
        {
            idPub = id;
            ProposerServiceMateriel pub = dal.ObtenirServicesMateriel(id);
            return View(pub);
        }

        [HttpPost]
        public IActionResult Modifier(ProposerServiceMateriel newMat)
        {
            if (!ModelState.IsValid)
                return View(newMat);

            // ProposerServiceMateriel mat = dal.ObtenirServicesMateriel(idPub);
            newMat.Id = idPub;
            dal.ModifierMat(newMat);

            return RedirectToAction("Recherche");
        }

        public IActionResult Payer(ProposerServiceMateriel pub)
        {
            
            string btPayer = "Payer " + pub.Prix;
            // ViewBag.PaymentAmount = amount;
            // string btPayer 
            string titreAchat;
            dal.ClasserMat(pub.Id);
            return View(btPayer);
        }
        /*
        public IActionResult Payer(string montant)
        {
            PaiementChargeViewModel btPayer = new PaiementChargeViewModel();
            btPayer.Montant = "Payer " + montant;
            // ViewBag.PaymentAmount = amount;
            // string btPayer 
            string titreAchat;
            return View(btPayer);
        }
        */
        public IActionResult Charge(string stripeEmail, string stripeToken)
        {

            var customers = new CustomerService();
            var charges = new ChargeService();
            //    var customer = customers.Create(new CustomerCreateOptions
            //    {
            //        Email = stripeEmail,
            //        SourceToken = stripeToken,

            //}); 

            //    var charge = charges.Create(new ChargeCreateOptions {

            //        Amount = 50,
            //        Currency = "Euro",
            //        Description = "Paiement de l'abonnement",
            //        CustomerId = customer.Id,
            //        ReceiptEmail = stripeEmail,
            //        Metadata = new Dictionary<string, string>() {
            //                    { "OrderId", "111" },
            //                    {"Postcode" , "ppp233"} }

            //    });
            //             if (charge.Status == "succeeded")
            //                    {
            //    string BalanceTransactionId = charge.BalanceTransactionId;
            //            return View();
            //            }else
            //            {


            //                }

            return View();
        }

    }
}

