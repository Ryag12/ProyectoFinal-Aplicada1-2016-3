using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProyectoFinal_Aplicada1.VentanasReportes
{
    public partial class FacturaReporte : Form
    {

        public int FacturaId { get; set; }

        public FacturaReporte()
        {
            InitializeComponent();
        }

        private void FacturaReporte_Load(object sender, EventArgs e)
        {
            Facturas factura = BLL.FacturasBLL.Buscar(FacturaId);
            FacturasBindingSource.Add(factura);
            foreach (var producto in BLL.ProductosBLL.Productos(FacturaId))
            {
                ProductosBindingSource.Add(producto);

            }
            this.reportViewer1.RefreshReport();
        }
    }
}
