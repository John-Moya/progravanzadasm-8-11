using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Veterinaria.Models
{
    
    public class Citas
    {
        [Key]
        public int Id { get; set; }

        public string  Paciente { get; set; }

        public string TipoDeMascota { get; set; }

        public string NombreMascota { get; set; }

        public DateTime FechaDeCita { get; set; }

        public string Descripcion { get; set; }

        public int CODIGOunicoPaciente { get; set; }

       

    }
}
