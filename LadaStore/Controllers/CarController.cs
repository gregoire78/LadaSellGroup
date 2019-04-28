using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using LadaStore.Data;
using LadaStore.Models;
using Microsoft.AspNetCore.Http;
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
        public async Task<IActionResult> Add(CarViewModel model)
        {
            var car = new Car
            {
                CarType = model.CarType,
                Year = model.Year,
                Kilometers = model.Kilometers,
                Description = model.Description,
                CarModelID = model.CarModelID
            };
            if (ModelState.IsValid)
            {
                using (var memoryStream = new MemoryStream())
                {
                    await model.Picture.CopyToAsync(memoryStream);
                    car.Picture = memoryStream.ToArray();
                }
                _context.Add(car);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index", "Home");
            }
            ViewData["CarModelID"] = new SelectList(_context.CarModels, "ID", "ModelName", car.CarModelID);
            return View(car);
        }
    }
}