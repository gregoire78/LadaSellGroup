using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LadaStore.Data;
using LadaStore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace LadaStore.Controllers
{
    public class CarController : BaseController
    {
        public CarController(LadaDbContext context) : base(context)
        {
        }


        [HttpGet]
        public IActionResult Add()
        {
            ViewData["CarModelID"] = new SelectList(_context.CarModels, "ID", "ModelName");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Add([Bind("CarType,CarModelID,Year,Kilometers,Description,Picture")] Car car )
        {
            if (ModelState.IsValid)
            {
                _context.Add(car);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index", "Home");
            }
            ViewData["CarModelID"] = new SelectList(_context.CarModels, "ID", "ModelName", car.CarModelID);
            return View(car);
        }
    }
}