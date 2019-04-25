using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LadaStore.Models
{
    public class Car : BaseModel
    {
        [Required]
        public string CarType { get; set; }

        public string UserID { get; set; }
        [ForeignKey("UserID")]
        public User User { get; set; }

        public int CarModelID { get; set; }
        [ForeignKey("CarModelID")]
        public CarModel CarModel { get; set; }

        [Required]
        public string Year { get; set; }

        [Required]
        public double Kilometers { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public byte[] Picture { get; set; }
    }
}