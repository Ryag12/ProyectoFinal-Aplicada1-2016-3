using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using DAL;
namespace BLL
{
   public  class TiposVehiculosBLL
    {
        public static bool Insertar(TiposVehiculos tVehiculos)
        {
            bool resultado = false;
            using (var conexion  =new  ProyectoFinalDb())
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
    }
}
