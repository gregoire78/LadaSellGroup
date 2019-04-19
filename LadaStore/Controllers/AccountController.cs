﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LadaStore.Data;
using LadaStore.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace LadaStore.Controllers
{
    public class AccountController : BaseController
    {
        private readonly SignInManager<User> signInManager;
        private readonly UserManager<User> userManager;

        public AccountController(SignInManager<User> signInManager, UserManager<User> userManager, LadaDbContext context) : base(context)
        {
            this.signInManager = signInManager;
            this.userManager = userManager;
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            /*if (DateTime.Now.AddYears(-18) <= model.BirthDate)
                ModelState.AddModelError("BirthDate", "Vous devez avoir plus de 18 ans.");*/

            if (ModelState.IsValid)
            {
                var user = new User
                {
                    UserName = model.Email,
                    Email = model.Email,
                    Lastname = model.Name,
                    Firstname = model.Firstname,
                    IsCustomer = true,
                    Address = model.Address,
                    Siret = model.Siret
                };
                var result = await userManager.CreateAsync(user, model.Password);
                if (result.Succeeded)
                {
                    return RedirectToAction("index", "home");
                }
                else
                {
                    ModelState.AddModelError("", result.ToString());
                }
            }
            return View(model);
        }
    }
}