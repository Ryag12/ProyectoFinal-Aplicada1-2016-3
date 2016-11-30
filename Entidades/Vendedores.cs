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

        public Vendedores(int vendedorId,string nombre,string apellido, string cedula,string telefonofijo,string telefonomovil,string zona,string rutaAsignada,string descripcion )
        {
            this.VendedorId = vendedorId;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Cedula = cedula;
            this.TelefonoFijo = telefonofijo;
            this.TelefonoMovil = telefonomovil;
            this.Zona = zona;
            this.RutaAsignada = rutaAsignada;
            this.Descripcion = descripcion;
            
        }
    }
}
