using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Entidades;
namespace ProyectoFinal_Aplicada1.RegistroProducto
{
    public partial class RegistrosProductos : Form
    {
        private List<Proveedores> prove;
        List<Productos> lista = null;
        public RegistrosProductos()
        {
            InitializeComponent();
            LlenaComboboxProveedor();
            prove = new List<Proveedores>();
        }

        private void ProductostextBox_MouseClick(object sender, MouseEventArgs e)
        {
            NombretextBox.Clear();
        }

        private void MarcatextBox_MouseClick(object sender, MouseEventArgs e)
        {
            MarcatextBox.Clear();
        }

        private void DescripciontextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void DescripcionProtextBox_MouseClick(object sender, MouseEventArgs e)
        {
            DescripcionProtextBox.Clear();
        }

        private void Editarbutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Limpiar()
        {
            NombretextBox.Clear();
            PrecioProdtextBox.Clear();
            UnidadTextBox2.Clear();
            MarcatextBox.Clear();
            DescripcionProtextBox.Clear();
            PaisProductotextBox.Clear();
            DireccionProductotextBox.Clear();

        }

        private void BuscarProductobutton_Click(object sender, EventArgs e)
        {
            var producto = ProductosBLL.Buscar(Convert.ToInt32(ProductoIdtextBox.Text));
            if (producto != null)
            {

                NombretextBox.Text = producto.Nombre;
                MarcatextBox.Text = producto.Marca;
                DescripcionProtextBox.Text = producto.Descripcion;
                DireccionProductotextBox.Text = producto.Direccion;
                PaisProductotextBox.Text = producto.Pais;
                UnidadTextBox2.Text = producto.Unidad.ToString();
                PrecioProdtextBox.Text = producto.Precio.ToString();
            }
            else
            {
                MessageBox.Show("Este Id no pertenece a ningun producto  " + Convert.ToInt32(ProductoIdtextBox.Text), "Error en la consulta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }        

        private void Registrarbutton_Click(object sender, EventArgs e)
        {
            Productos produc = new Productos();

            produc = LLenarFormulario();

            if(ProductosBLL.Insertar(produc))
            {
                MessageBox.Show("Producto agregado");
            }
        }

        //private Productos CompletarFormulario()
        //{
        //    Productos pr = new Productos();
        //    pr.productoId = Utilidades.ToInt(ProductoIdtextBox.Text);
        //    pr.productoId = Utilidades.ToInt(PrecioProdtextBox.Text);
        //    pr.productoId = Utilidades.ToInt(UnidadTextBox2.Text);
        //    pr.Nombre = NombretextBox.Text;
        //    pr.Marca = MarcatextBox.Text;
        //    pr.Descripcion = DescripcionProtextBox.Text;
        //    pr.Direccion = DireccionProductotextBox.Text;
        //    pr.Pais = PaisProductotextBox.Text;
        //    return pr;
            
        //}

        public void LlenaComboboxProveedor()
        {
            var lista = ProveedoresBLL.GetLista();
            if (lista.Count <= 0)
            {
                var proveedor1 = new Proveedores("Productos German");
                var proveedor2 = new Proveedores("Prod.Dolis");
                var proveedor3 = new Proveedores("Suavecito");
                var proveedor4 = new Proveedores("Dulce Tonis");
                var proveedor5 = new Proveedores("Dulce Chichi");
                var proveedor6 = new Proveedores("Dulce Pedro");

                ProveedoresBLL.Insertar(proveedor1);
                ProveedoresBLL.Insertar(proveedor2);
                ProveedoresBLL.Insertar(proveedor3);
                ProveedoresBLL.Insertar(proveedor4);
                ProveedoresBLL.Insertar(proveedor5);
                ProveedoresBLL.Insertar(proveedor6);
            }
            ProveedorProductoscomboBox.DataSource = lista;
            ProveedorProductoscomboBox.ValueMember = "Nombre";
            ProveedorProductoscomboBox.DisplayMember = " ProveedorId";
        }

        private Productos LLenarFormulario()
        {
            Productos Prod = new Productos();
            Prod.productoId = Utilidades.ToInt(ProductoIdtextBox.Text);
            Prod.Unidad = Utilidades.ToInt(UnidadTextBox2.Text);
            Prod.Precio = Utilidades.ToInt(PrecioProdtextBox.Text);
            Prod.Nombre = NombretextBox.Text;
            Prod.Marca = MarcatextBox.Text;
            Prod.Descripcion = DescripcionProtextBox.Text;
            Prod.Direccion = DireccionProductotextBox.Text;
            Prod.Pais = PaisProductotextBox.Text;
            return Prod;

        }

        private void DireccionProductotextBox_MouseClick(object sender, MouseEventArgs e)
        {
            DireccionProductotextBox.Clear();
        }

        private void PaisProductotextBox_MouseClick(object sender, MouseEventArgs e)
        {
            PaisProductotextBox.Clear();
        }

        private void ProductoIdtextBox_MouseClick(object sender, MouseEventArgs e)
        {
            ProductoIdtextBox.Clear();
        }

        private void RegistrosProductos_Load(object sender, EventArgs e)
        {
            
            //this.reportViewer1.RefreshReport();
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            ProductosBLL.Eliminar(ProductosBLL.Buscar(Convert.ToInt32(ProductoIdtextBox.Text)));
            Limpiar();
            MessageBox.Show("Vendedor ha sido eliminado");
        }
    }
}
