using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Productos
    {
        [Key]
        
        public int IdProducto { get; set; }        

        public string Nombre { get; set; }

        [Browsable(false)]
        public string Descripcion { get; set; }

        public Double Precio { get; set; }

        [Browsable(false)]
        public int Unidad { get; set; }

        [Browsable(false)]
        public string Marca { get; set; }

        [Browsable(false)]
        public string Telefono { get; set; }

        [Browsable(false)]
        public string Pais { get; set; }

        [Browsable(false)]
        public string Direccion { get; set; }

        public int Cantidad { get; set; }

        public Double Total { get; set; }

        public virtual List<Facturas> Facturas { get; set; }

        public Productos()
        {
            this.Facturas = new List<Entidades.Facturas>();
        }

        public Productos(int productoId, string nombre, string descripcion, int precio, int unidad,string marca,string telefono,string pais,string direccion)
        {
            this.IdProducto = productoId;
            this.Nombre = nombre;
            this.Descripcion = descripcion;
            this.Precio = precio;
            this.Unidad = unidad;
            this.Marca = marca;
            this.Telefono = telefono;
            this.Pais = pais;
            this.Direccion = direccion;
            this.Facturas = new List<Entidades.Facturas>();
        }

        public Productos(int productoId, string nombre, Double precio, int cantidad)
        {
            this.IdProducto = productoId;
            this.Nombre = nombre;
            this.Precio = precio;
            this.Cantidad = cantidad;
            this.Total = cantidad * precio;

            this.Facturas = new List<Entidades.Facturas>();
        }
    }
}
