using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SistemaClinica.Models;

namespace SistemaClinica.Data
{
    public class SistemaClinicaContext : DbContext
    {
        public SistemaClinicaContext (DbContextOptions<SistemaClinicaContext> options)
            : base(options)
        {
        }

        public DbSet<SistemaClinica.Models.Cliente> Cliente { get; set; }
    }
}
