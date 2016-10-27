using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Entidades;

namespace ProyectoFinal_Aplicada1.Consultas
{
    public partial class ConsultaUsuarios : Form
    {
        public ConsultaUsuarios()
        {
            InitializeComponent();
        }
        public List<Usuarios> lista = new List<Usuarios>();
        private void BuscarUsuabutton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(FiltrarUsuariotextBox.Text))
            {
                lista = BLL.UsuariosBLL.GetLista(Utilidades.ToInt(FiltrarUsuariotextBox.Text));
            }
            else
            {
                lista = BLL.UsuariosBLL.GetLista();
            }
            TblUsuariodataGridView.DataSource = lista;
        }
    }
}
