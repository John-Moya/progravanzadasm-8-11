using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FrenteMVCTours.Models;

namespace FrenteMVCTours.Data
{
    public class FrenteMVCToursContext : DbContext
    {
        public FrenteMVCToursContext (DbContextOptions<FrenteMVCToursContext> options)
            : base(options)
        {
        }

        public DbSet<FrenteMVCTours.Models.Tour> Tour { get; set; }
    }
}
