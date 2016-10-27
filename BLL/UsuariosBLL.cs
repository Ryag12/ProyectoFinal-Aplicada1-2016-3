using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using DAL;
namespace BLL
{
    public class UsuariosBLL
    {

        public static bool Guardar(Usuarios usuario)
        {
            bool retorno = false;
            try
            {
                var db = new ProyectoFinalDb();

                db.Usuario.Add(usuario);

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

            Usuarios usuario = Buscar(id);

            db.Usuario.Remove(usuario);
            db.SaveChanges();
        }

        public static Usuarios Buscar(int id)
        {
            var db = new ProyectoFinalDb();

            return db.Usuario.Find(id);
        }

        public static List<Usuarios> GetLista()
        {
            List<Usuarios> lista = new List<Usuarios>();

            var db = new ProyectoFinalDb();

            lista = db.Usuario.ToList();

            return lista;
        }

        public static List<Usuarios> GetLista(int usuarioId)
        {
            List<Usuarios> lista = new List<Usuarios>();

            var db = new ProyectoFinalDb();

            lista = db.Usuario.Where(p => p.Usuarioid == usuarioId).ToList();

            return lista;
        }

    }
}
