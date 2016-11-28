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
        public RegistrosProductos()
        {
            InitializeComponent();
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

        }

        private void BuscarProductobutton_Click(object sender, EventArgs e)
        {
            var produ = ProductosBLL.Buscar(Convert.ToInt32(ProductoIdtextBox.Text));
            CargarProducto(produ);
        }

        private void CargarProducto(Productos producto)
        {

            NombretextBox.Text = producto.Nombre;
            MarcatextBox.Text = producto.Marca;
            DescripcionProtextBox.Text = producto.Descripcion;
            DireccionProductotextBox.Text = producto.Direccion;
            PaisProductotextBox.Text = producto.Pais;
            UnidadTextBox2.Text = producto.Unidad.ToString();
            PrecioProdtextBox.Text = producto.Precio.ToString();
        }

        private void Registrarbutton_Click(object sender, EventArgs e)
        {
            Productos produc = new Productos();

            produc = CompletarFormulario();
            if(ProductosBLL.Insertar(produc))
            {
                MessageBox.Show("Producto agregado");
            }
        }

        private Productos CompletarFormulario()
        {
            Productos pr = new Productos();
            pr.productoId = Utilidades.ToInt(ProductoIdtextBox.Text);
            pr.productoId = Utilidades.ToInt(PrecioProdtextBox.Text);
            pr.productoId = Utilidades.ToInt(UnidadTextBox2.Text);
            pr.Nombre = NombretextBox.Text;
            pr.Marca = MarcatextBox.Text;
            pr.Descripcion = DescripcionProtextBox.Text;
            pr.Direccion = DireccionProductotextBox.Text;
            pr.Pais = PaisProductotextBox.Text;
            return pr;
            
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
    }
}
