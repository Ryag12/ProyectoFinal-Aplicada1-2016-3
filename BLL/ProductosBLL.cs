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
                    conexion.Productos.Add(productos);

                    conexion.SaveChanges();

                    obtener = true;

                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                    //throw;
                }
            }
            return obtener;
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
                    producto = conexion.Productos.Find(productoId);
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

            var db = new ProyectoFinalDb();

            lista = db.Productos.ToList();

            return lista;
        }

        public static List<Productos> GetLista(int idProducto)
        {
            List<Productos> lista = new List<Productos>();

            using (var conexion = new ProyectoFinalDb())
            {
                try
                {
                    lista = conexion.Productos.Where(p => p.productoId == idProducto).ToList();
                }
                catch (Exception)
                {

                    throw;
                }
            }

            return lista;
        }
    }
}
