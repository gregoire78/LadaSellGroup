using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LadaStore.Controllers;
using LadaStore.Data;
using LadaStore.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LadaStore.ApiControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private readonly LadaDbContext _context;
        public CarController(LadaDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Car>>> GetToto()
        {
            return await _context.Cars.ToListAsync();
        }

    }
}