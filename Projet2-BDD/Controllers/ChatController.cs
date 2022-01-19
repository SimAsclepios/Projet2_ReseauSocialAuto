using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Projet2_BDD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projet2_BDD.Controllers
{
    public class ChatController : Controller
    {
        public readonly ContextBDD _context;
        public readonly UserManager<AppUser> _userManager;

        public ChatController(ContextBDD context, UserManager<AppUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }


        public async Task<IActionResult> Acceuil()
        {
            var currentUser = await _userManager.GetUserAsync(User);

            ViewBag.currentUserName = currentUser.UserName;
      
            var messageries = await _context.Messageries.ToListAsync();
            return View();
        }
        public async Task<IActionResult> Create(Messagerie messagerie)
        {
            if (ModelState.IsValid)
            {
                messagerie.UserName = User.Identity.Name;
                var Emetteur = await _userManager.GetUserAsync(User);
                messagerie.UtilisateurId = Emetteur.Id;
                await _context.Messageries.AddAsync(messagerie);
                await _context.SaveChangesAsync();
                return Ok();
            }
            return Error();
        }

        private IActionResult Error()
        {
            throw new NotImplementedException();
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
