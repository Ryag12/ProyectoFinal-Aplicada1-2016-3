using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace ProyectoFinal_Aplicada1
{
    class ValidacionLetrayNumero
    {
        public void SoloLetras(KeyPressEventArgs e)
        {
            try
            {
                if(char.IsLetter(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if(char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if(char.IsSeparator(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                    MessageBox.Show("En este campo no esta permitido el uso de numeros");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void SoloNumero(KeyPressEventArgs e)
        {
            try
            {
                if(char.IsNumber(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if(char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }

                else if(char.IsSeparator(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                    MessageBox.Show("Este campo solo es permitido numeros");
                    
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
