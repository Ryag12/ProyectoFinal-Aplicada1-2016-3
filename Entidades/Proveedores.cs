using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Proveedores
    {
       [Key]
        public int ProveedorId { get; set; }

        public string Nombre { get; set; }
        public Proveedores( string nombre)
        {
            
            this.Nombre = nombre;
        }

        public Proveedores()
        {

        }

    }
}
