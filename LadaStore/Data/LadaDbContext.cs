using LadaStore.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LadaStore.Data
{
    public class LadaDbContext : IdentityDbContext<User>
    {
        public LadaDbContext(DbContextOptions<LadaDbContext> options) : base(options)
        {
        }

        public DbSet<Car> Cars { get; set; }

        public DbSet<CarModel> CarModels { get; set; }

        public DbSet<CarBrand> CarBrands { get; set; }

    }
}
