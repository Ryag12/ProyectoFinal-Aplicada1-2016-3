using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using DAL;
using System.Windows.Forms;

namespace BLL
{
   public  class ProveedoresBLL
    {

        public static bool Insertar(Proveedores proveedor)
        {
            bool resultado = false;
            using (var conexion = new ProyectoFinalDb())
            {
                try
                {
                    conexion.Proveedores.Add(proveedor);
                    conexion.SaveChanges();
                    resultado = true;
                }
                catch (Exception)
                {

                    throw;
                }
                return resultado;
            }
        }

        public static List<Proveedores> GetLista()
        {
            List<Proveedores> lista = new List<Proveedores>();

            using (var conexion = new ProyectoFinalDb())
            {
                try
                {
                    lista = conexion.Proveedores.ToList();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                    
                }
                return lista;
            }

        }
    }
}

