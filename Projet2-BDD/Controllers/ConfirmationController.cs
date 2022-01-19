using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projet2_BDD.Controllers
{
    public class ConfirmationController : Controller
    {
        public static ConfirmationController Confirmation = new ConfirmationController();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult MsgConfirmation()
        {
            return View();
        }
    }
}
