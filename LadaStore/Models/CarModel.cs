using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LadaStore.Models
{
    public class CarModel : BaseModel
    {
        public int CarBrandID { get; set; }
        [ForeignKey("CarBrandID")]
        public CarBrand CarBrands { get; set; }

        [Required]
        public string ModelName { get; set; }
    }
}
