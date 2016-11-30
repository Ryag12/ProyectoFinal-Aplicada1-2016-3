using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using DAL;
using System.Windows.Forms;
using System.Data.Entity;

namespace BLL
{
    public class ProductosBLL
    {
        public static bool Insertar(Productos productos)
        {
            bool obtener = false;
            using (var conexion = new ProyectoFinalDb())
            {
                try
                {
                    if (Buscar(productos.IdProducto) == null)
                    {
                        conexion.Producto.Add(productos);
                    }
                    else
                        conexion.Entry(productos).State = EntityState.Modified;
                    conexion.SaveChanges();

                    obtener = true;

                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                    //throw;
                }
                return obtener;
            }

        }
        public static void Eliminar(Productos productos)
        {
            using (var conexion = new ProyectoFinalDb())
            {
                try
                {

                    if (productos != null)
                    {
                        conexion.Entry(productos).State = EntityState.Deleted;

                        conexion.SaveChanges();

                    }

                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                    throw;
                }
            }
        }
        public static Productos Buscar(int productoId)
        {
            var producto = new Productos();
            using (var conexion = new ProyectoFinalDb())
            {
                try
                {
                    producto = conexion.Producto.Find(productoId);
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return producto;
        }
        public static List<Productos> GetLista()
        {
            List<Productos> lista = new List<Productos>();

            using (var conexion = new ProyectoFinalDb())
            {
                try
                {
                    lista = conexion.Producto.ToList();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                    throw;
                }
                return lista;
            }
        }

        public static List<Productos> GetLista(int idProducto)
        {
            List<Productos> lista = new List<Productos>();

            using (var conexion = new ProyectoFinalDb())
            {
                try
                {
                    lista = conexion.Producto.Where(p => p.IdProducto == idProducto).ToList();
                }
                catch (Exception)
                {

                    throw;
                }
            }

            return lista;
        }
        public static Double GetPrecio(int productoId)
        {
            Double precio = 0;
            using (var conexion = new ProyectoFinalDb())
            {
                try
                {
                    Productos p = conexion.Producto.Where(prod => prod.IdProducto == productoId).FirstOrDefault();
                    precio = p.Precio;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                    throw;
                }
                return precio;
            }
        }
        public static List<Productos> ListaCombo()
        {
            List<Productos> lista = null;
            using (var conexion = new ProyectoFinalDb())
            {
                try
                {
                    lista = conexion.Producto.Where(p => p.Cantidad <= 0 && p.Total <= 0).ToList();
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return lista;
        }
        public static List<Productos> Productos(int facturaId)
        {
            var producto = new List<Productos>();
            using (var conexion = new ProyectoFinalDb())
            {
                try
                {
                    var factura = BLL.FacturasBLL.Buscar(facturaId);
                    if(factura != null)
                        producto = factura.Productos;
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return producto;
        }
    }
}
