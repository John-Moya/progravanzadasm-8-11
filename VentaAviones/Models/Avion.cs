using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VentaAviones.Models
{
    public class Avion
    {
        [Key]
        public int Id { get; set; }
        
        public string Marca { get; set; }

        public string Tamano { get; set; }

        public int Pasajeros { get; set; }

        public string Color { get; set; }

        public int Turbinas { get; set; }

    }
}
