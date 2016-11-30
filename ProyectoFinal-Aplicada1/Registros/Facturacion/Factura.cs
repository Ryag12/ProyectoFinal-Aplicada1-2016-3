using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProyectoFinal_Aplicada1.Registros.Facturacion
{
    public partial class Factura : Form
    {
        Facturas factura;
        public Factura()
        {
            InitializeComponent();

            AgregarVendedor();
            AgregarProductos();
            factura = new Facturas();
        }

        public void AgregarVendedor()
        {
            while (true)
            {
                var lista = BLL.VendedorBLL.GetLista();
                if (lista.Count <= 0)
                {
                    var ventana = new RegistroVendedor.RegistroVendedor();
                    ventana.ShowDialog();
                }
                else
                {
                    ElegirVendedorcomboBox.DataSource = null;
                    ElegirVendedorcomboBox.DataSource = lista;
                    ElegirVendedorcomboBox.ValueMember = "VendedorId";
                    ElegirVendedorcomboBox.DisplayMember = "Nombre";
                    break;
                }
            }
               
        }

        public void AgregarProductos()
        {
            while (true)
            {
                var lista = BLL.ProductosBLL.GetLista();
                if (lista.Count <= 0)
                {
                    var ventana = new RegistroProducto.RegistrosProductos();
                    ventana.ShowDialog();
                }
                else
                {
                    ElegirProductocomboBox.DataSource = null;
                    ElegirProductocomboBox.DataSource = lista;
                    ElegirProductocomboBox.ValueMember = "ProductoId";
                    ElegirProductocomboBox.DisplayMember = "Nombre";
                    break;
                }
            }
        }
        private void NuevoDetallebutton_Click(object sender, EventArgs e)
        {

        }

        private void GuardarDetallebutton_Click(object sender, EventArgs e)
        {
            factura.Fecha = FechadateTimePicker.Value;
            factura.Vendedor = ElegirVendedorcomboBox.Text;
            factura.Unidad = factura.ventas.Count();
            if (BLL.FacturasBLL.Insertar(factura))
            {
                MessageBox.Show("Guardo");
            }
        }

        private void Factura_Load(object sender, EventArgs e)
        {

        }

        private void CalcularTotal(Facturas factura)
        {
            Double total = 0;
            foreach (var detalle in factura.ventas)
            {
                total += detalle.Total;
            }
            factura.Total = total;
        }

        private void AgregarProdbutton_Click(object sender, EventArgs e)
        {
            factura.ventas.Add(new VentasProductos(ElegirProductocomboBox.Text, Utilidades.ToInt(CantidadArttextBox.Text), BLL.ProductosBLL.GetPrecio((int)ElegirProductocomboBox.SelectedValue)));
            DetalledataGridView.DataSource = null;
            DetalledataGridView.DataSource = factura.ventas;
            CalcularTotal(factura);
            ProductostextBox.Text = factura.ventas.Count().ToString();
            TotaltextBox.Text = factura.Total.ToString();
        }
    }
}
