using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LadaStore.Data;
using Microsoft.AspNetCore.Mvc;

namespace LadaStore.Controllers
{
    public class BaseController : Controller
    {
        protected readonly LadaDbContext _context;
        public BaseController(LadaDbContext context)
        {
            _context = context;
        }
    }
}