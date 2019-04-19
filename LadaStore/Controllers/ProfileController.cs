using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LadaStore.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using LadaStore.Models;
using System.Diagnostics;
using Microsoft.AspNetCore.Identity;

namespace LadaStore.Controllers
{
    public class ProfileController : BaseController
    {
        private readonly UserManager<User> userManager;

        public ProfileController(UserManager<User> userManager, LadaDbContext context) : base(context)
        {
            this.userManager = userManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        // POST: Profile/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}