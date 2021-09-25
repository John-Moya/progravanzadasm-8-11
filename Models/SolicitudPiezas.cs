using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tareaS1.Models
{
    public class SolicitudPiezas
    {

        public int Id { get; set; }
        public string Email { get; set; }
        public string Direccion { get; set; }
        public string Repuesto { get; set; }
        public string Marca { get; set; }
        public DateTime? Anio { get; set; }
        public int? Cantidad { get; set; }
    }

}
