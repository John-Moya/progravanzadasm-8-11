﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Veterinaria.Models;

namespace Veterinaria.Data
{
    public class VeterinariaContext : DbContext
    {
        public VeterinariaContext (DbContextOptions<VeterinariaContext> options)
            : base(options)
        {
        }

        public DbSet<Veterinaria.Models.PacienteMascota> PacienteMascota { get; set; }
    }
}
