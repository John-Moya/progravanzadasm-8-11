using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Vet2.Models;

namespace Vet2.Data
{
    public class Vet2Context : DbContext
    {
        public Vet2Context (DbContextOptions<Vet2Context> options)
            : base(options)
        {
        }

        public DbSet<Vet2.Models.Citas> Citas { get; set; }
    }
}
