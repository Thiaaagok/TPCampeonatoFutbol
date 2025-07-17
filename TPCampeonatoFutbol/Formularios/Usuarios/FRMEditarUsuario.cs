using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPCampeonatoFutbol.Modelos;
using TPCampeonatoFutbol.Servicios;
using TPCampeonatoFutbol.Servicios.Interfaces;

namespace TPCampeonatoFutbol.Formularios.Usuarios
{
    public partial class FRMEditarUsuario : Form
    {
        private CLSUsuario usuarioEditar;
        private readonly UsuarioService usuariosService = new UsuarioService();
        public FRMEditarUsuario(CLSUsuario usuario)
        {
            InitializeComponent();
            usuarioEditar = usuario;
            SetearPropiedades();
            this.FormBorderStyle = FormBorderStyle.None;
            this.BackColor = Color.FromArgb(39, 57, 80);
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void SetearPropiedades()
        {
            nombreUsuarioTxt.Text = usuarioEditar.Usuario;
            comboRol.Text = usuarioEditar.Rol;
        }

        private void cerrarAplicacionBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void editarUsuarioBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nombreUsuarioTxt.Text) ||
                 string.IsNullOrWhiteSpace(comboRol.Text))
            {
                MessageBox.Show("Por favor, completa todos los campos correctamente.");
                return;
            }

            usuarioEditar = new CLSUsuario(usuarioEditar.Id, usuarioEditar.Usuario, usuarioEditar.Contrasenia, comboRol.Text);
            usuariosService.editarUsuario(usuarioEditar);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
