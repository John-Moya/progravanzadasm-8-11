using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Vet2.Models
{
    public class Citas
    {
        [Key]

        public int ID { get; set; }

        public string NombreCliente { get; set; }

        public string NombreMascota { get; set; }

        public string FechaNacimientoMascota { get; set; }

        public string Asunto { get; set; }

        public string Telefono { get; set; }

        public string Email { get; set; }

        public string Raza { get; set; }

        public string TipoMascota { get; set; }

    }
}
