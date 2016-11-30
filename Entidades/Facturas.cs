using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Facturas
    {
        [Key]
        public int FacturaId { get; set; }

        public Double Total { get; set; }

        public int Unidad { get; set; }

        public DateTime Fecha { get; set; }

        public Double Abono { get; set; }

        public string Vendedor { get; set; }

        public virtual List<VentasProductos>  ventas{ get; set; }
        public Facturas(int facturaId)
        {
            this.FacturaId = facturaId;
            this.ventas = new List<VentasProductos>();
        }

        public Facturas()
        {
            this.ventas = new List<VentasProductos>();
        }

    }
}
