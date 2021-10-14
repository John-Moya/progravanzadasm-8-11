using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using VENTADECARROS2S4.MODELOS;

namespace VENTADECARROS2S4.Data
{
    public class VENTADECARROS2S4Context : DbContext
    {
        public VENTADECARROS2S4Context (DbContextOptions<VENTADECARROS2S4Context> options)
            : base(options)
        {
        }

        public DbSet<VENTADECARROS2S4.MODELOS.Automovil> Automovil { get; set; }
    }
}
