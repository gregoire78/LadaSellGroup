using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LadaStore.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

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
    }
}