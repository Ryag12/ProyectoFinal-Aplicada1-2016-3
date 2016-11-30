using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class VentasProductos
    {
        [Key]
        public int VentaProductoId { get; set; }

        public string NombreProducto { get; set; }

        public int Cantidad { get; set; }

        public Double Total { get; set; }

        public virtual List<Facturas> Facturas { get; set; }

        public VentasProductos(string nombrePro, int cantidad,Double precio)
        {
            this.NombreProducto = nombrePro;
            this.Cantidad = cantidad;
            this.Total = Cantidad * precio;
            Facturas = new List<Entidades.Facturas>();
        }

        public VentasProductos()
        {
            Facturas = new List<Entidades.Facturas>();
        }
    }
}
