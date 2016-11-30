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
        public List<Vendedores> lista = new List<Vendedores>();

        private void ConsultaVendedores_Load(object sender, EventArgs e)
        {

        }
        private void CargarVendedores()
        {
            while (true)
            {
                var lista = BLL.VendedorBLL.GetLista();
                if (lista.Count() <= 0)
                {
                    MessageBox.Show("Debe de Ingresar al menos un 'VENDEDOR'");

                }
                else
                {
                    FiltrarVendedorcomboBox.DataSource = lista;
                    FiltrarVendedorcomboBox.ValueMember = "VendedorId";
                    FiltrarVendedorcomboBox.DisplayMember = "Nombre";
                    break;
                }
            }
        }
        private void BuscarConsultabutton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(FiltrarVendedorcomboBox.Text))
            {
                lista = BLL.VendedorBLL.GetLista(Utilidades.ToInt(FiltrarVendedorcomboBox.Text));
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
