using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using tareaS1.Models;

namespace tareaS1.Data
{
    public class tareaS1Context : DbContext
    {
        public tareaS1Context (DbContextOptions<tareaS1Context> options)
            : base(options)
        {
        }

        public DbSet<tareaS1.Models.SolicitudPiezas> SolicitudPiezas { get; set; }
    }
}
