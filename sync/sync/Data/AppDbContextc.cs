using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using sync.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sync.Data
{
    public class AppDbContext:IdentityDbContext
    {
        public AppDbContext(DbContextOptions options):base(options)
        {

        }

        DbSet<Setting> Settings { get; set; }
        DbSet<CustomUsercs> CustomUsercs { get; set; }
        DbSet<Details> Details { get; set; }
        DbSet<Social> Socials { get; set; }

    }
}
