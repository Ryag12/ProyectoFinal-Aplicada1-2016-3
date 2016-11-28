using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using DAL;
using System.Windows.Forms;

namespace BLL
{
    public class TiposVehiculosBLL
    {
        public static bool Insertar(TiposVehiculos tVehiculos)
        {
            bool resultado = false;
            using (var conexion = new ProyectoFinalDb())
            {
                try
                {
                    conexion.TiposVehiculos.Add(tVehiculos);
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

        public static List<TiposVehiculos> GetLista()
        {
            List<TiposVehiculos> lista = new List<TiposVehiculos>();

            using (var db = new ProyectoFinalDb())
            {
                try
                {
                    lista = db.TiposVehiculos.ToList();
                }
                catch (Exception e )
                {
                    MessageBox.Show(e.ToString());
                   // throw;
                }
                return lista;
            }
          
        }
    }
}
