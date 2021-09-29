using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Veterinaria.Models
{
    public class PacienteMascota
    {
        [Key]
        public int id { get; set; }
        public string NombreMascota { get; set; }
        public string Raza { get; set; }
        public DateTime FechaNacimientoMascota { get; set; }
        public string NombreDueno { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public string Correo { get; set; }
        public string Cedula { get; set; }


    }
}
