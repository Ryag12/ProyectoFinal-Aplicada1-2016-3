using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Entidades;
using BLL;
namespace ProyectoFinal_Aplicada1.RegistroVendedor
{
    public partial class RegistroVendedor : Form
    {
        ValidacionLetrayNumero vl = new ValidacionLetrayNumero();
        public RegistroVendedor()
        {
            InitializeComponent();
            TipoVehiculocomboBox.Enabled = false;
            TipoVehiculo2comboBox.Enabled = false;
            DescripciontextBox.Enabled = false;
            VehiculoAsignadocomboBox.Enabled = false;
            RutaAsignadatextBox.Enabled = false;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBoxNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Vendedores vendedores = new Vendedores();
            vendedores = LLenarFormulario();
            if(!Confirmar())
            {
                MessageBox.Show("Todos los campos deben estar llenos");

            }
            else if(VendedorBLL.Guardar(vendedores))
            {
                MessageBox.Show("EL vendedor ha sido registrado");
            }
        }

        private bool Confirmar()
        {
            bool retornar = true;

            if(string.IsNullOrEmpty(NombretextBox.Text) && (string.IsNullOrEmpty(ApellidotextBox.Text)) && (string.IsNullOrEmpty(SexocomboBox.Text)) &&
                (string.IsNullOrEmpty(CedulamaskedTextBox.Text)) && (string.IsNullOrEmpty(TelefonoFijomaskedTextBox.Text)) && (string.IsNullOrEmpty(DirecciontextBox.Text)) &&
                (string.IsNullOrEmpty(ZonatextBox.Text)) && (string.IsNullOrEmpty(VehiculoPropiocomboBox.Text)) &&(string.IsNullOrEmpty(TipoVehiculo2comboBox.Text)) && (string.IsNullOrEmpty(DescripciontextBox.Text)) &&
                (string.IsNullOrEmpty(VehiculoAsignadocomboBox.Text)) && (string.IsNullOrEmpty(TipoVehiculo2comboBox.Text)) &&(string.IsNullOrEmpty(RutaAsignadatextBox.Text)))
            {

                errorProvider1.SetError(NombretextBox,"Debes al menos introducir un nombre");
                errorProvider2.SetError(ApellidotextBox, "Introducir al menos un apellido");
                errorProvider3.SetError(SexocomboBox, "Seleccione un sexo!");
                errorProvider4.SetError(CedulamaskedTextBox, "Complete el campo Cedula ");
                errorProvider5.SetError(TelefonoFijomaskedTextBox, "Introduzca un numero del telefono ");
                errorProvider6.SetError(DirecciontextBox, "Debe colocar una direccion");
                errorProvider7.SetError(ZonatextBox, "Para continuar coloque la zona del vendedor");

                retornar = false;
            }

            return retornar;

        }

        private Vendedores LLenarFormulario()
        {
            Vendedores vendedores = new Vendedores();
            vendedores.VendedorId = Utilidades.ToInt(VendedorIdtextBox.Text);
            vendedores.Nombre = NombretextBox.Text;
            vendedores.Apellido = ApellidotextBox.Text;
            vendedores.Cedula = CedulamaskedTextBox.Text;
            vendedores.TelefonoFijo = TelefonoFijomaskedTextBox.Text;
            vendedores.TelefonoMovil = TelefonoMovilmaskedTextBox.Text;
            vendedores.Direccion = DirecciontextBox.Text;
            vendedores.Zona = ZonatextBox.Text;

            return vendedores;
            
        }

        private void VehiculoPropiocomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (VehiculoPropiocomboBox.Text.Equals ("Si"))
            {
                TipoVehiculocomboBox.Enabled = true;

                DescripciontextBox.Enabled = true;

                RutaAsignadatextBox.Enabled = true;
            }
            else if (VehiculoPropiocomboBox.Text.Equals("No"))
            {
                TipoVehiculocomboBox.Enabled = false;
                TipoVehiculo2comboBox.Enabled = true;
                DescripciontextBox.Enabled = true;
                VehiculoAsignadocomboBox.Enabled = true;
                RutaAsignadatextBox.Enabled = true;
            }
            
        }

        private void NombretextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            vl.SoloLetras(e);
        }

        private void ApellidotextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            vl.SoloLetras(e);
        }

        private void CedulamaskedTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            vl.SoloNumero(e);
        }

        private void TelefonoMovilmaskedTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            vl.SoloNumero(e);
        }

        private void TelefonoFijomaskedTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            vl.SoloNumero(e);
        }

        private void VendedorIdtextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            vl.SoloNumero(e);
        }

        private void Editarbutton_Click(object sender, EventArgs e)
        {

        }
    }
}
