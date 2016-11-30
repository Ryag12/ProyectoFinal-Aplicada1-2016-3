using DAL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BLL
{
    public class FacturasBLL
    {
        public static bool Insertar(Facturas factura)
        {
            bool resultado = false;
            using (var conexion = new ProyectoFinalDb())
            {
                try
                {
                    conexion.Factura.Add(factura);
                    conexion.SaveChanges();
                    resultado = true;
                }
                catch (Exception e )
                {
                    MessageBox.Show(e.ToString());
                    throw;
                }
            }
            return resultado;
        }
    }
}
