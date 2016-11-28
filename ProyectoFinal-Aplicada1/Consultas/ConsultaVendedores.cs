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
            DesdedateTimePicker.Value = HastadateTimePicker.Value = DateTime.Now;
        }
        
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
            var lista = BLL.VendedorBLL.GetLista(Convert.ToInt32(FiltrarVendedorcomboBox.Text));
            TblConsudataGridView.DataSource = null;
            TblConsudataGridView.DataSource = lista;
        }
        private void TblConsudataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

      
    }
}
