using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Veterinaria.Models
{
    public class vet
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Telefono { get; set; }
        public string Correo { get; set; }
        public string Mascota { get; set; }
        public string Servicio { get; set; }
    }
}
