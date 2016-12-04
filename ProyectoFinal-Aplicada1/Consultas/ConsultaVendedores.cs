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
        //private void CargarVendedores()
        //{
        //    while (true)
        //    {
        //        var lista = BLL.VendedorBLL.GetListaId((int)(FiltrarVendedorcomboBox.SelectedValue)) ;
        //        if (lista.Count() <= 0)
        //        {
        //            MessageBox.Show("Debe de Ingresar al menos un 'VENDEDOR'");
        //            var ventana = new RegistroVendedor.RegistroVendedor();

        //        }
        //        else
        //        {
        //            FiltrarVendedorcomboBox.DataSource = lista;
        //            FiltrarVendedorcomboBox.ValueMember = "VendedorId";
        //            FiltrarVendedorcomboBox.DisplayMember = "Nombre";
        //            break;
        //        }
        //    }
        //}
        private void BuscarConsultabutton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(FiltrarVendedortextBox.Text))
            {
                lista = BLL.VendedorBLL.GetListaId(Utilidades.ToInt(FiltrarVendedortextBox.Text));
                var ventana = new RegistroVendedor.RegistroVendedor();
            }
            else
            {
                lista = BLL.VendedorBLL.GetLista();
            }
            TblConsudataGridView.DataSource = lista;
        }

        public void LimpiarCampo()
        {
            FiltrarVendedortextBox.Clear();
            TblConsudataGridView.DataSource = null;
        }
        private void TblConsudataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Editarbutton_Click(object sender, EventArgs e)
        {
            LimpiarCampo();
        }

        private void EliminarVenConsbutton_Click(object sender, EventArgs e)
        {
            int selFila = TblConsudataGridView.CurrentCell.RowIndex;
            TblConsudataGridView.Rows.RemoveAt(selFila);
        }
    }
}
