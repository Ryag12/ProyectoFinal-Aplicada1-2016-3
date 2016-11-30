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
                var lista = BLL.ProductosBLL.ListaCombo();
                if (lista.Count <= 0)
                {
                    var ventana = new RegistroProducto.RegistrosProductos();
                    ventana.ShowDialog();
                }
                else
                {
                    ElegirProductocomboBox.DataSource = null;
                    ElegirProductocomboBox.DataSource = lista;
                    ElegirProductocomboBox.ValueMember = "IdProducto";
                    ElegirProductocomboBox.DisplayMember = "Nombre";
                    break;
                }
            }
        }
        private void NuevoDetallebutton_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void GuardarDetallebutton_Click(object sender, EventArgs e)
        {
            factura.Fecha = FechadateTimePicker.Value;
            factura.Vendedor = ElegirVendedorcomboBox.Text;
            factura.Unidad = factura.Productos.Count();
            if (BLL.FacturasBLL.Insertar(factura))
            {
                MessageBox.Show("Guardo");
                LimpiarCampos();
            }
        }

        private void Factura_Load(object sender, EventArgs e)
        {

        }

        private void CalcularTotal(Facturas factura)
        {
            Double total = 0;
            foreach (var detalle in factura.Productos)
            {
                total += detalle.Total;
            }
            factura.Total = total;
        }

        private void AgregarProdbutton_Click(object sender, EventArgs e)
        {
            int id = (int)ElegirProductocomboBox.SelectedValue;
            factura.Productos.Add(new Productos(id,ElegirProductocomboBox.Text, BLL.ProductosBLL.GetPrecio(id), Utilidades.ToInt(CantidadArttextBox.Text)));
            DetalledataGridView.DataSource = null;
            DetalledataGridView.DataSource = factura.Productos;
            CalcularTotal(factura);
            ProductostextBox.Text = factura.Productos.Count().ToString();
            TotaltextBox.Text = factura.Total.ToString();
        }

        private void BuscarFactbutton_Click(object sender, EventArgs e)
        {
            factura = BLL.FacturasBLL.Buscar(Utilidades.ToInt(FacturaIdtextBox.Text));
           if(factura!=null)
            {
                ProductostextBox.Text = factura.Productos.Count().ToString();
                TotaltextBox.Text = factura.Total.ToString();
                DetalledataGridView.DataSource = null;
                DetalledataGridView.DataSource = factura.Productos;
            }
        }

        private void LimpiarCampos()
        {
            DetalledataGridView.DataSource = null;
            CantidadArttextBox.Clear();
            ProductostextBox.Clear();
            TotaltextBox.Clear();
            FechadateTimePicker.Value = DateTime.Today;
            FacturaIdtextBox.Clear();
            factura = new Facturas();
        }

        private void EliminarDetallebutton_Click(object sender, EventArgs e)
        {
            BLL.FacturasBLL.Eliminar(BLL.FacturasBLL.Buscar(Utilidades.ToInt(FacturaIdtextBox.Text)));
            LimpiarCampos();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var reporte = new VentanasReportes.FacturaReporte();
            reporte.FacturaId = Utilidades.ToInt(FacturaIdtextBox.Text);
            reporte.Show();
        }
    }
}
