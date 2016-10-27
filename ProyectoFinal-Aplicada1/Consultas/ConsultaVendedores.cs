using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Entidades;

namespace ProyectoFinal_Aplicada1.Consultar
{
    public partial class ConsultaVendedores : Form
    {
        public ConsultaVendedores()
        {
            InitializeComponent();
        }
        public List<Vendedor> lista = new List<Vendedor>();

        private void ConsultaVendedores_Load(object sender, EventArgs e)
        {

        }

        private void BuscarConsultabutton_Click(object sender, EventArgs e)
        {

            if (!String.IsNullOrEmpty(FiltrartextBox.Text))
            {

                lista = BLL.VendedorBLL.GetLista(Utilidades.ToInt(FiltrartextBox.Text));
            }
            else
            {
                lista = BLL.VendedorBLL.GetLista();
            }

            TblConsudataGridView.DataSource = lista;
        }

        private void TblConsudataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
