using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using apiReatc;

namespace apiReatc.Data
{
    public class apiReatcContext : DbContext
    {
        public apiReatcContext (DbContextOptions<apiReatcContext> options)
            : base(options)
        {
        }

        public DbSet<apiReatc.Articulo> Articulo { get; set; }
    }
}
