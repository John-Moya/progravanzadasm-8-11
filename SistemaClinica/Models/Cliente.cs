using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaClinica.Models
{
    public class Cliente
    {
        [Key]
        public int Id_cliente { get; set; }
        public string Nombre {  get; set; }
        public string Apellidos {  get; set; }
        public string Email {  get; set; }
        [DataType(DataType.Date)]
        public DateTime? Cita {  get; set; }
        public string Telefono {  get; set; }
    }
}
