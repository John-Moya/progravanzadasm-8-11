using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using VentaAviones.Models;

namespace VentaAviones.Data
{
    public class VentaAvionesContext : DbContext
    {
        public VentaAvionesContext (DbContextOptions<VentaAvionesContext> options)
            : base(options)
        {
        }

        public DbSet<VentaAviones.Models.Avion> Avion { get; set; }
    }
}
