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

        public int Unidad { get; set; }

        public string Marca { get; set; }

        public string Telefono { get; set; }

        public string Pais { get; set; }

        public string Direccion { get; set; }

        public Productos()
        {

        }

        public Productos(int productoId, string nombre, string descripcion, int precio, int unidad,string marca,string telefono,string pais,string direccion)
        {
            this.productoId = productoId;
            this.Nombre = nombre;
            this.Descripcion = descripcion;
            this.Precio = precio;
            this.Unidad = unidad;
            this.Marca = marca;
            this.Telefono = telefono;
            this.Pais = pais;
            this.Direccion = direccion;
        }
    }
}
