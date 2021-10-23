using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Automotores.Models;

namespace Automotores.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Automotores.Models.Vehiculo> Vehiculo { get; set; }
        public DbSet<Automotores.Models.Servicios> Servicios { get; set; }
    }
}
