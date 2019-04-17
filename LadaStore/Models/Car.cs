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

        [ForeignKey("User")]
        public string UserID { get; set; }

        [ForeignKey("CarModels")]
        public string CarModelID { get; set; }

        [Required]
        public string Year { get; set; }

        [Required]
        public double Kilometers { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public string Picture { get; set; }
    }
}
