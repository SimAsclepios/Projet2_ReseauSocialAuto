using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Projet2_BDD.Dal;
using Projet2_BDD.Models;
using Projet2_BDD.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projet2_BDD.Controllers
{
    public class RechercheController : Controller
    {
        private IDal dal;
        private readonly IWebHostEnvironment _hostEnvironment;
        public RechercheController(IWebHostEnvironment hostEnvironment)
        {
            this.dal = new dDal();
            this._hostEnvironment = hostEnvironment;
        }


        public IActionResult Index()
        {
            return View();
        }

        /*
        public IActionResult AncienIndex()
        {
           int id =  int.Parse(User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier)?.Value);
            try
            {
                AllPost allList = new AllPost();
                allList.Mat = dal.ObtenirListServicesMateriel(id);
                allList.Dmd = dal.ObtenirListServicesImmateriel(id);
                allList.Event = dal.ObtenirListEvenement(id);

                return View(allList);
            }
            catch
            {
                return View(new AllPost());
            }
        }
        */

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




    }
}
