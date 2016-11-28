using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using DAL;
using System.Data.Entity;
using System.Windows.Forms;

namespace BLL
{
    public class VendedorBLL
    {
        public static bool Guardar(Vendedores vendedor)
        {
            bool retorno = false;
            using (var conexion = new ProyectoFinalDb())
            {
                try
                {
                    if (Buscar(vendedor.VendedorId) == null)
                    {
                        conexion.Vendedor.Add(vendedor);
                    }
                    else
                        conexion.Entry(vendedor).State = EntityState.Modified;
                    conexion.SaveChanges();

                    retorno = true;
                }
                catch (Exception)
                {

                    throw;
                }

                return retorno;
            }
        }

        public static void Eliminar(Vendedores vendedor)
        {
            using (var conexion = new ProyectoFinalDb())
            {
                try
                {

                    if (vendedor != null)
                    {
                        conexion.Entry(vendedor).State = EntityState.Deleted;

                        conexion.SaveChanges();

                    }

                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                    throw;
                }
            }

            //bool obtener = false;
            //using (var conexion = new ProyectoFinalDb())
            //{
            //    try
            //    {
            //        conexion.Entry(agregado).State = EntityState.Deleted;
            //        conexion.SaveChanges();
            //        obtener = true;

            //    }
            //    catch (Exception)
            //    {

            //        throw;
            //    }
            //    return obtener;
            //}


        }

        public static Vendedores Buscar(int vendedorId)
        {
            var vendedor = new Vendedores();
            using (var conexion = new ProyectoFinalDb())
            {
                try
                {
                    vendedor = conexion.Vendedor.Find(vendedorId);
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return vendedor;
        }

        public static List<Vendedores> GetLista()
        {
            List<Vendedores> lista = new List<Vendedores>();

            using (var db = new ProyectoFinalDb())
            {
                try
                {
                    lista = db.Vendedor.ToList();
                }
                catch (Exception)
                {

                    throw;
                }
                return lista;
            }

        }

        public static List<Vendedores> GetLista(int vendedorId)
        {
            List<Vendedores> lista = new List<Vendedores>();

            var db = new ProyectoFinalDb();

            lista = db.Vendedor.Where(p => p.VendedorId == vendedorId).ToList();

            return lista;
        }
        public static List<Vendedores> GetListNombre(string nombre)
        {

            List<Vendedores> lista = new List<Vendedores>();
            using (var conexion = new ProyectoFinalDb())
            {
                try
                {
                    lista = conexion.Vendedor.Where(n => string.Equals(n.Nombre, nombre)).ToList();
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

