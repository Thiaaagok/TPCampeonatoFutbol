using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPCampeonatoFutbol.Funciones;

namespace TPCampeonatoFutbol
{
    public partial class RegisterForm : Form
    {
        ManejoArchivos manejoArchivos = new ManejoArchivos();
        public RegisterForm()
        {
            InitializeComponent();
            AsignarDiseños();
        }

        private void AsignarDiseños()
        {
            // diseño formulario
            this.FormBorderStyle = FormBorderStyle.None;
            this.BackColor = Color.FromArgb(39, 57, 80);
            this.StartPosition = FormStartPosition.CenterScreen;

            //diseño nombre usuario txt
            NombreUsuariotxt.TabStop = false;
            NombreUsuariotxt.BackColor = Color.FromArgb(39, 57, 80);
            NombreUsuariotxt.BorderStyle = BorderStyle.None;
            NombreUsuariotxt.Font = new Font("Century Gothic", 12F);
            NombreUsuariotxt.ForeColor = Color.Silver;
            NombreUsuariotxt.Size = new Size(408, 30);

            //diseño contraseña txt
            Contraseniatxt.TabStop = false;
            Contraseniatxt.BackColor = Color.FromArgb(39, 57, 80);
            Contraseniatxt.BorderStyle = BorderStyle.None;
            Contraseniatxt.Font = new Font("Century Gothic", 12F);
            Contraseniatxt.ForeColor = Color.Silver;
            Contraseniatxt.Size = new Size(408, 30);

            repetirContraseniatxt.TabStop = false;
            repetirContraseniatxt.BackColor = Color.FromArgb(39, 57, 80);
            repetirContraseniatxt.BorderStyle = BorderStyle.None;
            repetirContraseniatxt.Font = new Font("Century Gothic", 12F);
            repetirContraseniatxt.ForeColor = Color.Silver;
            repetirContraseniatxt.Size = new Size(408, 30);

            //diseño crear cuenta boton
            CrearCuentaBtn.BackColor = Color.FromArgb(33, 53, 73);
            CrearCuentaBtn.FlatStyle = FlatStyle.Flat;
            CrearCuentaBtn.FlatAppearance.BorderColor = Color.FromArgb(85, 159, 127);
            CrearCuentaBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(20, 20, 20);
            CrearCuentaBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(70, 118, 126);
            CrearCuentaBtn.ForeColor = Color.LightGray;
            CrearCuentaBtn.Size = new Size(208, 40);

            iniciarSesionBtn.BackColor = Color.FromArgb(33, 53, 73);
            iniciarSesionBtn.FlatStyle = FlatStyle.Flat;
            iniciarSesionBtn.FlatAppearance.BorderColor = Color.FromArgb(85, 159, 127);
            iniciarSesionBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(20, 20, 20);
            iniciarSesionBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(70, 118, 126);
            iniciarSesionBtn.ForeColor = Color.LightGray;
            iniciarSesionBtn.Size = new Size(150, 40);
        }

        private void Register()
        {
            string ruta = "usuarios.txt";
            string usuarioNuevo = NombreUsuariotxt.Text;
            string contraseniaNueva = Contraseniatxt.Text;
            string repetirContrasenia = repetirContraseniatxt.Text;

            if (string.IsNullOrEmpty(usuarioNuevo) || string.IsNullOrEmpty(contraseniaNueva))
            {
                MessageBox.Show("Usuario y contraseña no pueden estar vacíos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var usuarios = manejoArchivos.ObtenerTodos(ruta);
            bool usuarioExiste = usuarios.Any(linea =>
            {
                var partes = linea.Split(',');
                return partes.Length >= 1 && partes[0] == usuarioNuevo;
            });

            if (usuarioExiste)
            {
                MessageBox.Show("El nombre de usuario ingresado ya existe. Intenta con uno diferente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (contraseniaNueva != repetirContrasenia)
            {
                MessageBox.Show("Las contraseñas no coinciden.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            string nuevoRegistro = $"{usuarioNuevo},{contraseniaNueva}";
            manejoArchivos.GuardarNuevo(ruta, nuevoRegistro);

            MessageBox.Show("Usuario creado exitosamente.");
            this.Hide();
            LoginForm login = new LoginForm();
            login.Show();
        }

        private void CrearCuentaBtn_Click(object sender, EventArgs e)
        {
            if (NombreUsuariotxt.Text != "" && Contraseniatxt.Text != "" && repetirContraseniatxt.Text != "")
            {
                Register();
            }
            else
            {
                MessageBox.Show("Por favor, completar los campos correctamente");
            }
        }

        private void iniciarSesionBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm login = new LoginForm();
            login.Show();
        }

        private void cerrarAplicacionBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
