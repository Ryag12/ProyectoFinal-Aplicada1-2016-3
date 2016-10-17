using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Entidades;
using BLL;
namespace ProyectoFinal_Aplicada1.RegistroVendedor
{
    public partial class RegistroVendedor : Form
    {
        public RegistroVendedor()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBoxNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Vendedores vendedores = new Vendedores();

            if(VendedorBLL.Guardar(vendedores))
            {
                MessageBox.Show("EL vendedor ha sido registrado");
            }
        }

        private Vendedores LLenarFormulario()
        {
            Vendedores vendedores = new Vendedores();
            vendedores.VendedorId = Utilidades.ToInt(VendedorIdtextBox.Text);
            vendedores.Nombre = NombretextBox.Text;
            vendedores.Apellido = ApellidotextBox.Text;
            vendedores.Cedula = CedulamaskedTextBox.Text;
            vendedores.TelefonoFijo = TelefonoFijomaskedTextBox.Text;
            vendedores.TelefonoMovil = TelefonoMovilmaskedTextBox.Text;
            vendedores.Direccion = DirecciontextBox.Text;
            vendedores.Zona = ZonatextBox.Text;

            return vendedores;
            
        }
            
        
    }
}
