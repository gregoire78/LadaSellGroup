using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LadaStore.Models
{
    public class CarViewModel
    {
        [Display(Name = "Type de voiture")]
        [Required(ErrorMessage = "{0} obligatoire")]
        public string CarType { get; set; }

        [Display(Name = "Model de voiture")]
        [Required(ErrorMessage = "{0} obligatoire")]
        public int CarModelID { get; set; }

        [Display(Name = "Année de la voiture")]
        [Required(ErrorMessage = "{0} obligatoire")]
        public string Year { get; set; }

        [Display(Name = "Kilometrage de la voiture")]
        [Required(ErrorMessage = "{0} obligatoire")]
        public double Kilometers { get; set; }

        [Display(Name = "Description")]
        [Required(ErrorMessage = "{0} obligatoire")]
        public string Description { get; set; }

        [Display(Name = "Photo")]
        [Required(ErrorMessage = "{0} obligatoire")]
        public IFormFile Picture { get; set; }
    }
}
