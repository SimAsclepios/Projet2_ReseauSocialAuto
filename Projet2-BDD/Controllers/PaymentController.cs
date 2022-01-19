using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Stripe;
using Projet2_BDD.Models;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using System.IO;
using Projet2_BDD.ViewModels;

namespace Projet2_BDD.Controllers
{
    public class PaymentController : Controller
    {
        
        // private int amount = 100;
        public IActionResult Payer(string montant)
        {
            PaiementChargeViewModel btPayer = new PaiementChargeViewModel();
            btPayer.Montant = "Payer " + montant;
            // ViewBag.PaymentAmount = amount;
           // string btPayer 
            string titreAchat;
            return View(btPayer);
        }


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

