using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Entidades
{
    
   public class Vendedores
    {
        [Key]

        
        public int VendedorId { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public string Sexo { get; set; }

        public string Cedula { get; set; }

        public string TelefonoFijo { get; set; }

        public string TelefonoMovil { get; set; }

        public string Direccion { get; set; }

        public string Zona { get; set; }

        public string TipoVehiculo { get; set; }

        public string VehiculoPropio { get; set; }

        public string VehiculoAsignado { get; set; }

        public string RutaAsignada { get; set; }

        public string Descripcion { get; set; }
        
        public Vendedores()
        {

        }
    }
}
