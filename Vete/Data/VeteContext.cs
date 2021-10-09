using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Vete.Models;

namespace Vete.Data
{
    public class VeteContext : DbContext
    {
        public VeteContext (DbContextOptions<VeteContext> options)
            : base(options)
        {
        }

        public DbSet<Vete.Models.Cita> Cita { get; set; }
    }
}
