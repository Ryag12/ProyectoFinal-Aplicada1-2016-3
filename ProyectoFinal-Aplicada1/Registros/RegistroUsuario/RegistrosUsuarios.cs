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
namespace ProyectoFinal_Aplicada1.Registros.RegistroUsuario
{
    
    public partial class RegistrosUsuarios : Form
    {
        ValidacionLetrayNumero vl  = new ValidacionLetrayNumero();
        public RegistrosUsuarios()
        {
            InitializeComponent();
            UsuarioIdtextBox.Enabled = false;
            NombreUsuariotextBox.Enabled = false;
            ContrasenatextBox.Enabled = false;
            RepContratextBox.Enabled = false;
            BuscarUsbutton.Enabled = false;
            label1.Enabled = false;
            label2.Enabled = false;
            label3.Enabled = false;
        }

        private void CrearUsbutton_Click(object sender, EventArgs e)
        {
            
            var usuarios = new Usuarios();
            usuarios = LLenarFormulario();
            if (!Confirmar())
            {
                MessageBox.Show("Todos los campos deben estar llenos");

            }
            else if  (UsuariosBLL.Guardar(usuarios))
            {
                MessageBox.Show("Usuarios registrado con exito!!");
            }
        }

        private bool Confirmar()
        {
            bool retorno = true;

            if(string.IsNullOrEmpty(UsuarioIdtextBox.Text) && (string.IsNullOrEmpty(NombreUsuariotextBox.Text))&&(string.IsNullOrEmpty(ContrasenatextBox.Text))
              && (string.IsNullOrEmpty(RepContratextBox.Text)))
            {
                errorProvider1.SetError(UsuarioIdtextBox, "Por favor debes colocar un UsuarioID");
                errorProvider2.SetError(NombreUsuariotextBox, "Tienes que registra un nombre");
                errorProvider3.SetError(ContrasenatextBox, "Debes colocar una contraseña");
                errorProvider4.SetError(RepContratextBox, "Confirme su contraseña");

                retorno = false;
            }


            return retorno;
        }

        private Usuarios LLenarFormulario()
        {
           var usuario = new Usuarios();
            usuario.Usuarioid = Utilidades.ToInt(UsuarioIdtextBox.Text);
            usuario.Nombre =NombreUsuariotextBox.Text;
            usuario.Contrasena = ContrasenatextBox.Text;
            //usuario.RepContrasena = RepContratextBox.Text;
                        
            return usuario;

        }

        private void UsuarioIdtextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void NombreUsuariotextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void NombreUsuariotextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            vl.SoloLetras(e);
        }

        private void CancelarUsbutton_Click(object sender, EventArgs e)
        {
            UsuarioIdtextBox.Enabled = true;
            NombreUsuariotextBox.Enabled = true;
            ContrasenatextBox.Enabled = true;
            RepContratextBox.Enabled = true;
            BuscarUsbutton.Enabled = true;
            label1.Enabled = true;
            label2.Enabled = true;
            label3.Enabled = true;
        }

        private void UsuarioIdtextBox_MouseClick(object sender, MouseEventArgs e)
        {
            UsuarioIdtextBox.Clear();
        }

        private void NombreUsuariotextBox_MouseClick(object sender, MouseEventArgs e)
        {
            NombreUsuariotextBox.Clear();
        }

        private void ContrasenatextBox_MouseClick(object sender, MouseEventArgs e)
        {
            ContrasenatextBox.Clear();
        }

        private void RepContratextBox_MouseClick(object sender, MouseEventArgs e)
        {
            RepContratextBox.Clear();
        }

        private void BuscarUsbutton_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(UsuarioIdtextBox.Text);
            var uS = UsuariosBLL.Buscar(num);

            if(uS != null)
            {
                NombreUsuariotextBox.Text = uS.Nombre;
                ContrasenatextBox.Text = uS.Contrasena;
            }
        }
    }
    
}
