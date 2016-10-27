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
        public static bool Guardar(Vendedor vendedor)
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

            Vendedor vendedor = Buscar(id);

            db.Vendedor.Remove(vendedor);
            db.SaveChanges();
        }

        public static Vendedor Buscar(int id)
        {
            var db = new ProyectoFinalDb();

            return db.Vendedor.Find(id);
        }

        public static List<Vendedor> GetLista()
        {
            List<Vendedor> lista = new List<Vendedor>();

            var db = new ProyectoFinalDb();

            lista = db.Vendedor.ToList();

            return lista;
        }

        public static List<Vendedor> GetLista(int vendedorId)
        {
            List<Vendedor> lista = new List<Vendedor>();

            var db = new ProyectoFinalDb();

            lista = db.Vendedor.Where(p => p.VendedorId == vendedorId).ToList();

            return lista;
        }

    }
}

