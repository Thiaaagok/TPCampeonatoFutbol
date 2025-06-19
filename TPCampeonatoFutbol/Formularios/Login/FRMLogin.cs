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
    public partial class FRMLogin : Form
    {
        private ManejoArchivos manejoArchivos = new ManejoArchivos();

        public FRMLogin()
        {
            InitializeComponent();
            AsignarDiseños();
        }

        private void FRMLogin_Load(object sender, EventArgs e)
        {
            labelDummy.Focus();
        }

        private void IniciarSesionbtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(NombreUsuariotxt.Text) && !string.IsNullOrWhiteSpace(Contraseniatxt.Text))
            {
                Login();
            }
            else
            {
                MessageBox.Show("Por favor, completar los campos correctamente");
            }
        }

        private void crearCuentaBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            FRMRegister registerForm = new FRMRegister();
            registerForm.Show();
        }

        private void cerrarAplicacionBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cerrarAplicacionBtn_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }


        /// <summary>
        /// Aplica diseño personalizado a los controles del formulario.
        /// </summary>
        private void AsignarDiseños()
        {
            // Diseño formulario
            this.FormBorderStyle = FormBorderStyle.None;
            this.BackColor = Color.FromArgb(39, 57, 80);
            this.StartPosition = FormStartPosition.CenterScreen;

            // Diseño del textbox de nombre de usuario
            NombreUsuariotxt.BackColor = Color.FromArgb(39, 57, 80);
            NombreUsuariotxt.BorderStyle = BorderStyle.None;
            NombreUsuariotxt.Font = new Font("Century Gothic", 12F);
            NombreUsuariotxt.ForeColor = Color.Silver;
            NombreUsuariotxt.Size = new Size(408, 30);

            // Diseño del textbox de contraseña
            Contraseniatxt.BackColor = Color.FromArgb(39, 57, 80);
            Contraseniatxt.BorderStyle = BorderStyle.None;
            Contraseniatxt.Font = new Font("Century Gothic", 12F);
            Contraseniatxt.ForeColor = Color.Silver;
            Contraseniatxt.Size = new Size(408, 30);

            // Diseño botón Iniciar Sesión
            IniciarSesionbtn.BackColor = Color.FromArgb(33, 53, 73);
            IniciarSesionbtn.FlatStyle = FlatStyle.Flat;
            IniciarSesionbtn.FlatAppearance.BorderColor = Color.FromArgb(85, 159, 127);
            IniciarSesionbtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(20, 20, 20);
            IniciarSesionbtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(70, 118, 126);
            IniciarSesionbtn.ForeColor = Color.LightGray;
            IniciarSesionbtn.Size = new Size(408, 40);

            // Diseño botón Crear Cuenta
            crearCuentaBtn.BackColor = Color.FromArgb(33, 53, 73);
            crearCuentaBtn.FlatStyle = FlatStyle.Flat;
            crearCuentaBtn.FlatAppearance.BorderColor = Color.FromArgb(85, 159, 127);
            crearCuentaBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(20, 20, 20);
            crearCuentaBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(70, 118, 126);
            crearCuentaBtn.ForeColor = Color.LightGray;
            crearCuentaBtn.Size = new Size(208, 40);
        }

        /// <summary>
        /// Valida las credenciales del usuario leyendo desde el archivo "usuarios.txt".
        /// </summary>
        private void Login()
        {
            bool loginCorrecto = false;

            try
            {
                List<string> lineas = manejoArchivos.ObtenerTodos("usuarios.txt");

                foreach (var linea in lineas)
                {
                    string[] partes = linea.Split(',');
                    if (partes.Length < 3) continue;

                    string usuario = partes[1];
                    string contrasenia = partes[2];

                    if (usuario == NombreUsuariotxt.Text && contrasenia == Contraseniatxt.Text)
                    {
                        loginCorrecto = true;
                        break;
                    }
                }

                if (!loginCorrecto)
                {
                    MessageBox.Show("Usuario o Contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    this.Hide();
                    MainMDI home = new MainMDI();
                    home.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar iniciar sesión: " + ex.Message);
            }
        }
    }
}
