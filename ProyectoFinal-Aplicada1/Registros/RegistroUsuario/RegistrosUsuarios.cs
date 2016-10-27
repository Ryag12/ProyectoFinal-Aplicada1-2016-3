using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Entidades;

namespace ProyectoFinal_Aplicada1.Registros.RegistroUsuario
{
    public partial class RegistrosUsuarios : Form
    {
        public RegistrosUsuarios()
        {
            InitializeComponent();
        }

        private void CrearUsbutton_Click(object sender, EventArgs e)
        {
            var usuarios = new Usuarios();
            usuarios = LLenarFormulario();
            if (!Confirmar())
            {
                MessageBox.Show("Todos los campos deben estar llenos");

            }
            else if (VendedorBLL.Guardar(vendedores))
            {
                MessageBox.Show("EL vendedor ha sido registrado");
            }
        }

        private Usuarios LLenarFormulario()
        {
           var usuario = new Usuarios();
            usuario.Usuarioid = Utilidades.ToInt(UsuarioIdtextBox.Text);
            usuario.Nombre =NombreUsuariotextBox.Text;
            usuario.Contrasena = ContrasenatextBox.Text;
            usuario.
            

            return usuario;

        }
    }
    }
}
