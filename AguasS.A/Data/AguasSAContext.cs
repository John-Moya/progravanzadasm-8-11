using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AguasS.A.Models;

namespace AguasS.A.Data
{
    public class AguasSAContext : DbContext
    {
        public AguasSAContext (DbContextOptions<AguasSAContext> options)
            : base(options)
        {
        }

        public DbSet<AguasS.A.Models.Tour> Tour { get; set; }
    }
}
