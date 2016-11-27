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

        public static bool Eliminar(int id)
        {
            bool obtener = false;
            using (var db = new ProyectoFinalDb())
            {
                try
                {
                    Usuarios us = db.Usuario.Find(id);

                    db.Usuario.Remove(us);

                    db.SaveChanges();

                    obtener = true;
                }
                catch (Exception)
                {

                    throw;
                }
                return obtener;
            }

        }

        public static Usuarios Buscar(int id)
        {

            var us = new Usuarios();
            var conn = new ProyectoFinalDb();

            us = conn.Usuario.Find(id);
            return us;

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
