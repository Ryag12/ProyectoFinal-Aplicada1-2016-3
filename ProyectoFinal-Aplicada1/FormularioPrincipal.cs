using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BLL;
using Entidades;

namespace ProyectoFinal_Aplicada1
{
    public partial class FormularioPrincipal : Form
    {
        public FormularioPrincipal()
        {
            InitializeComponent();
        }

        private void registroVendedorToolStripMenuItem_Click(object sender, EventArgs e)
        {

           RegistroVendedor.RegistroVendedor rVendedor = new RegistroVendedor.RegistroVendedor();
           // rVendedor.MdiParent = this;
            rVendedor.Show();

        }

        private void registroToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroProducto.RegistrosProductos rProducto = new RegistroProducto.RegistrosProductos();
            rProducto.Show();
        }

        private void crearFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consultar.ConsultaVendedores rConsultaVend = new Consultar.ConsultaVendedores();
            rConsultaVend.Show();

            
        }
    }
}
