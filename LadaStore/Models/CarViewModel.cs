using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LadaStore.Models
{
    public class CarViewModel
    {
        public string CarType { get; set; }

        public int CarModelID { get; set; }

        public string Year { get; set; }

        public double Kilometers { get; set; }

        public string Description { get; set; }

        public IFormFile Picture { get; set; }
    }
}
