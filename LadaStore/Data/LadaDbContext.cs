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

    }
}
