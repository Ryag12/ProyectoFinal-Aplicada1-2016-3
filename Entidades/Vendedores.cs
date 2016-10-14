using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
   public class Vendedores
    {
        public int VendedorId { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public string Sexo { get; set; }

        public string Cedula { get; set; }

        public string TelefonoFijo { get; set; }

        public string TelefonoMovil { get; set; }

        public string Direccion { get; set; }

        public string TipoVehiculo { get; set; }
    }
}
