using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


using System.Web.Http.Cors;
using System.Threading.Tasks;
using System.Web.Cors;
using System.Net.Http;
using System.Threading;



namespace apiReatc
{
    public class Articulo
    {
        [Key]
        public int Id { get; set; }

        public string Nombre { get; set; }

        public string Descripcion { get; set; }

        public string Precio { get; set; }
    }
}
