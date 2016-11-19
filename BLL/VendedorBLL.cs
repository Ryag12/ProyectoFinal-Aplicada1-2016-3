using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using DAL;
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

                    conexion.Vendedor.Add(vendedor);

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

        public static bool Eliminar(int id)
        {
            bool otbner = false;
            using (var db = new ProyectoFinalDb())
            {
                try
                {
                    Vendedores vendedor = db.Vendedor.Find(id);

                    db.Vendedor.Remove(vendedor);
                    db.SaveChanges();
                    otbner = true;
                }
                catch (Exception)
                {

                    throw;
                }
                return otbner;
            }

            
        }

        public static bool Buscar(int id)
        {
            bool r = false;
            using (var db = new ProyectoFinalDb())
            {
                try
                {
                    db.Vendedor.Find(id);
                    r = true;
                }
                catch (Exception)
                {

                    throw;
                }
                return r;
            }    
        }

        public static List<Vendedores> GetLista()
        {
            List<Vendedores> lista = new List<Vendedores>();

            var db = new ProyectoFinalDb();

            lista = db.Vendedor.ToList();

            return lista;
        }

        public static List<Vendedores> GetLista(int vendedorId)
        {
            List<Vendedores> lista = new List<Vendedores>();

            var db = new ProyectoFinalDb();

            lista = db.Vendedor.Where(p => p.VendedorId == vendedorId).ToList();

            return lista;
        }

    }
}

