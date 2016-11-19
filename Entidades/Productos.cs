using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Productos
    {
        [Key]
        public int productoId { get; set; }

        public string Nombre { get; set; }

        public string Descripcion { get; set; }

        public int Precio { get; set; }

        public string Proveedor { get; set; }

        public int Unidad { get; set; }

        public string Marca { get; set; }
    }
}
