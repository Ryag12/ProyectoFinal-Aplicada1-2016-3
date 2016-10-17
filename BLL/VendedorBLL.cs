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
            try
            {
                ProyectoFinalDb db = new ProyectoFinalDb();

                db.Vendedor.Add(vendedor);

                db.SaveChanges();

                retorno = true;
            }
            catch (Exception)
            {

                throw;
            }

            return retorno;
        }

        public static void Eliminar(int id)
        {
            var db = new ProyectoFinalDb();

            Vendedores vendedor = Buscar(id);

            db.Vendedor.Remove(vendedor);
            db.SaveChanges();
        }

        public static Vendedores Buscar(int id)
        {
            var db = new ProyectoFinalDb();

            return db.Vendedor.Find(id);
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

