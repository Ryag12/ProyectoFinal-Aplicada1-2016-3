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
        private List<TiposVehiculos> tv;
        public RegistroVendedor()
        {
            InitializeComponent();
            LlenaCombobox();
            tv = new List<TiposVehiculos>();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            if (VehiculoPnoradioButton.Checked)

                VehiculoAsignado.Visible = true;

            else
                VehiculoAsignado.Visible = false;
        }

        private void textBoxNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            Vendedores vendedores = new Vendedores();

            vendedores = LLenarFormulario();

            if (!Confirmar())
            {
                MessageBox.Show("Todos los campos deben estar llenos");

            }
            else if (VendedorBLL.Guardar(vendedores))
            {

                MessageBox.Show("EL vendedor ha sido registrado");
            }
        }

        private bool Confirmar()
        {
            bool error = true;
            //NombreVendedortextBox.Text ==string.Empty
            if (string.IsNullOrEmpty(NombreVendedortextBox.Text) && (string.IsNullOrEmpty(ApellidotextBox.Text)) &&
                (string.IsNullOrEmpty(CedulamaskedTextBox.Text)) && (string.IsNullOrEmpty(TelefonoFijomaskedTextBox.Text)) && (string.IsNullOrEmpty(DirecciontextBox.Text)) &&
                (string.IsNullOrEmpty(ZonatextBox.Text)) && (string.IsNullOrEmpty(TipoVehiculocomboBox.Text)) && (string.IsNullOrEmpty(DescripciontextBox.Text)) &&
                (string.IsNullOrEmpty(RutaAsignadatextBox.Text)))
            {

                errorProvider1.SetError(NombreVendedortextBox, "Debes al menos introducir un nombre");
                errorProvider2.SetError(ApellidotextBox, "Introducir al menos un apellido");

                errorProvider4.SetError(CedulamaskedTextBox, "Complete el campo Cedula ");
                errorProvider5.SetError(TelefonoFijomaskedTextBox, "Introduzca un numero del telefono ");
                errorProvider6.SetError(DirecciontextBox, "Debe colocar una direccion");
                errorProvider7.SetError(ZonatextBox, "Para continuar coloque la zona del vendedor");
                error = false;
            }
            return error;
        }

        private void Limpiar()
        {
            VendedorIdtextBox.Clear();
            NombreVendedortextBox.Clear();
            ApellidotextBox.Clear();
            MujerradioButton.Checked = false;
            HombreradioButton.Checked = false;
            VehiculoPsiradioButton.Checked = false;
            VehiculoPnoradioButton.Checked = false;
            VasignadonoradioButton.Checked = false;
            VasignadoSiradioButton3.Checked = false;
            CedulamaskedTextBox.Clear();
            TelefonoFijomaskedTextBox.Clear();
            TelefonoMovilmaskedTextBox.Clear();
            DirecciontextBox.Clear();
            ZonatextBox.Clear();
            DescripciontextBox.Clear();
            RutaAsignadatextBox.Clear();
            TipoVehiculocomboBox.SelectedValue = 1;

        }

        private Vendedores LLenarFormulario()
        {
            Vendedores vendedores = new Vendedores();
            vendedores.VendedorId = Utilidades.ToInt(VendedorIdtextBox.Text);
            vendedores.Nombre = NombreVendedortextBox.Text;
            vendedores.Apellido = ApellidotextBox.Text;
            vendedores.Cedula = CedulamaskedTextBox.Text;
            vendedores.TelefonoFijo = TelefonoFijomaskedTextBox.Text;
            vendedores.TelefonoMovil = TelefonoMovilmaskedTextBox.Text;
            vendedores.Direccion = DirecciontextBox.Text;
            vendedores.Zona = ZonatextBox.Text;
            if (MujerradioButton.Checked)
                vendedores.Sexo = "Mujer";
            else
                vendedores.Sexo = "Hombre";

            if (VehiculoPsiradioButton.Checked)
                vendedores.VehiculoAsignado = "Si";
            else
                vendedores.VehiculoAsignado = "No";

            if (VasignadoSiradioButton3.Checked)
                vendedores.VehiculoPropio = "Si";
            else
                vendedores.VehiculoPropio = "No";
            vendedores.TipoVehiculo = TipoVehiculocomboBox.Text;

            vendedores.RutaAsignada = RutaAsignadatextBox.Text;
            vendedores.Descripcion = DescripciontextBox.Text;

            return vendedores;

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
            Limpiar();
        }

        private void BuscarVendedorbutton_Click(object sender, EventArgs e)
        {
            var vendedor = VendedorBLL.Buscar(Convert.ToInt32(VendedorIdtextBox.Text));
            if (vendedor != null)
            {
                NombreVendedortextBox.Text = vendedor.Nombre;
                ApellidotextBox.Text = vendedor.Apellido;
                if (vendedor.Sexo.Equals("Mujer"))
                {
                    MujerradioButton.Checked = true;

                }
                else
                    HombreradioButton.Checked = true;

                if (vendedor.VehiculoPropio.Equals("Si"))
                {
                    VehiculoPsiradioButton.Checked = true;
                }
                else
                    VehiculoPnoradioButton.Checked = true;
                if (vendedor.VehiculoAsignado.Equals("Si"))
                {
                    VasignadoSiradioButton3.Checked = true;
                }
                else
                    VasignadonoradioButton.Checked = true;
                CargarVendedores(vendedor);
            }
            else
            {
                MessageBox.Show("Este Id no pertenece a ningun Vendedor  " + Convert.ToInt32(VendedorIdtextBox.Text), "Error en la consulta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void CargarVendedores(Vendedores vendedor)
        {

            CedulamaskedTextBox.Text = vendedor.Cedula.ToString();
            TelefonoFijomaskedTextBox.Text = vendedor.TelefonoFijo.ToString();
            TelefonoMovilmaskedTextBox.Text = vendedor.TelefonoMovil.ToString();
            DirecciontextBox.Text = vendedor.Direccion;
            ZonatextBox.Text = vendedor.Zona;
            TipoVehiculocomboBox.SelectedValue = vendedor.TipoVehiculo;
            DescripciontextBox.Text = vendedor.Descripcion;
            RutaAsignadatextBox.Text = vendedor.RutaAsignada;
        }

        private void VendedorIdtextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            VendedorBLL.Eliminar(VendedorBLL.Buscar(Convert.ToInt32(VendedorIdtextBox.Text)));
            Limpiar();
            MessageBox.Show("Vendedor ha sido eliminado");
        }

        private int Toint(string letra)
        {
            int numero = 0;
            int.TryParse(Text, out numero);
            return numero;
        }

        public void LlenaCombobox()
        {
            var lista = TiposVehiculosBLL.GetLista();
            if (lista.Count <= 0)
            {
                var tipoVeh = new TiposVehiculos("Carro Turismo");
                var tipoVeh2 = new TiposVehiculos("Furgoneta");
                var tipoVeh3 = new TiposVehiculos("Camion");
                var tipoVeh4 = new TiposVehiculos("Motor");
                var tipoVeh5 = new TiposVehiculos("Camioneta");

                TiposVehiculosBLL.Insertar(tipoVeh);
                TiposVehiculosBLL.Insertar(tipoVeh2);
                TiposVehiculosBLL.Insertar(tipoVeh3);
                TiposVehiculosBLL.Insertar(tipoVeh4);
                TiposVehiculosBLL.Insertar(tipoVeh5);
            }
            TipoVehiculocomboBox.DataSource = lista;
            TipoVehiculocomboBox.ValueMember = "Nombres";
            TipoVehiculocomboBox.DisplayMember = " TiposVehiculosId";
        }

        private void TipoVehiculocomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RegistroVendedor_Load(object sender, EventArgs e)
        {

        }
    }
}
