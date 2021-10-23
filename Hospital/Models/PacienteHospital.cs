using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hospital.Models
{
    public class PacienteHospital
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int PacienteID { get; set; }
        public string Enfermedad { get; set; }
    }
}
