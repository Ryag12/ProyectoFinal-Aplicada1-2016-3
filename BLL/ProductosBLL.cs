using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using DAL;
using System.Windows.Forms;

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

        public static bool Eliminar(int id)
        {
            bool retornar = false;
            using (var conexion = new ProyectoFinalDb())
            {

                try
                {
                    Productos productos = conexion.Productos.Find(id);

                    conexion.Productos.Remove(productos);

                    conexion.SaveChanges();

                    retornar = true;
                }
                catch (Exception)
                {

                    throw;
                }

                return retornar;
            }
        }

        public static Productos Buscar(int ProductoId)
        {
            var producto = new Productos();
            using (var conexion = new ProyectoFinalDb())
            {
                try
                {
                    producto = conexion.Productos.Find(ProductoId);
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

            var db = new ProyectoFinalDb();

            lista = db.Productos.Where(p => p.productoId == idProducto).ToList();

            return lista;
        }
    }
}
