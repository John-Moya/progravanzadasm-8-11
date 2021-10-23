using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hospital.Models
{
    public class EmpleadoHospital
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int EmpleadoID { get; set; }
        public string Correo { get; set; }
    }
}
