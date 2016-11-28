using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProyectoFinal_Aplicada1.Registros.VentanaReportes
{
    public partial class Vendedores : Form
    {
        public int vendedorId { get; set; }
        public Vendedores()
        {
            InitializeComponent();
        }

        private void Vendedores_Load(object sender, EventArgs e)
        {
            foreach (var vendedor in BLL.VendedorBLL.GetLista())
            {
                VendedoresBindingSource.Add(vendedor);
            }
            this.reportViewer1.RefreshReport();
        }
    }
}
