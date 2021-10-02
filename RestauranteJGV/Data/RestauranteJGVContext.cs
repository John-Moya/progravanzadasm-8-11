using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RestauranteJGV.Models;

namespace RestauranteJGV.Data
{
    public class RestauranteJGVContext : DbContext
    {
        public RestauranteJGVContext (DbContextOptions<RestauranteJGVContext> options)
            : base(options)
        {
        }

        public DbSet<RestauranteJGV.Models.Producto> Producto { get; set; }
    }
}
