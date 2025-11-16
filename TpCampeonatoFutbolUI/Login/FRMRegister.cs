using System;
using System.Drawing;
using System.Windows.Forms;
using TpCampeonatoFubolBLL;

namespace TPCampeonatoFutbol
{
    public partial class FRMRegister : Form
    {
        
        public FRMRegister()
        {
            InitializeComponent();
            AsignarDiseños();
        }

        private void CrearCuentaBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(NombreUsuariotxt.Text) &&
                !string.IsNullOrWhiteSpace(Contraseniatxt.Text) &&
                !string.IsNullOrWhiteSpace(repetirContraseniatxt.Text))
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
            FRMLogin login = new FRMLogin();
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

        /// <summary>
        /// Aplica el diseño personalizado a los controles del formulario.
        /// </summary>
        private void AsignarDiseños()
        {
            // Diseño formulario
            this.FormBorderStyle = FormBorderStyle.None;
            this.BackColor = Color.FromArgb(39, 57, 80);
            this.StartPosition = FormStartPosition.CenterScreen;

            // Diseño textbox NombreUsuario
            NombreUsuariotxt.BackColor = Color.FromArgb(39, 57, 80);
            NombreUsuariotxt.BorderStyle = BorderStyle.None;
            NombreUsuariotxt.Font = new Font("Century Gothic", 12F);
            NombreUsuariotxt.ForeColor = Color.Silver;
            NombreUsuariotxt.Size = new Size(408, 30);

            // Diseño textbox Contraseña
            Contraseniatxt.BackColor = Color.FromArgb(39, 57, 80);
            Contraseniatxt.BorderStyle = BorderStyle.None;
            Contraseniatxt.Font = new Font("Century Gothic", 12F);
            Contraseniatxt.ForeColor = Color.Silver;
            Contraseniatxt.Size = new Size(408, 30);

            // Diseño textbox Repetir contraseña
            repetirContraseniatxt.BackColor = Color.FromArgb(39, 57, 80);
            repetirContraseniatxt.BorderStyle = BorderStyle.None;
            repetirContraseniatxt.Font = new Font("Century Gothic", 12F);
            repetirContraseniatxt.ForeColor = Color.Silver;
            repetirContraseniatxt.Size = new Size(408, 30);

            // Diseño botón Crear cuenta
            CrearCuentaBtn.BackColor = Color.FromArgb(33, 53, 73);
            CrearCuentaBtn.FlatStyle = FlatStyle.Flat;
            CrearCuentaBtn.FlatAppearance.BorderColor = Color.FromArgb(85, 159, 127);
            CrearCuentaBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(20, 20, 20);
            CrearCuentaBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(70, 118, 126);
            CrearCuentaBtn.ForeColor = Color.LightGray;
            CrearCuentaBtn.Size = new Size(208, 40);

            // Diseño botón Iniciar sesión
            iniciarSesionBtn.BackColor = Color.FromArgb(33, 53, 73);
            iniciarSesionBtn.FlatStyle = FlatStyle.Flat;
            iniciarSesionBtn.FlatAppearance.BorderColor = Color.FromArgb(85, 159, 127);
            iniciarSesionBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(20, 20, 20);
            iniciarSesionBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(70, 118, 126);
            iniciarSesionBtn.ForeColor = Color.LightGray;
            iniciarSesionBtn.Size = new Size(150, 40);
        }

        /// <summary>
        /// Crea un nuevo usuario si los datos son válidos.
        /// </summary>
        private readonly UsuariosBLL usuarioBLL = new UsuariosBLL();

        private void Register()
        {
            string usuarioNuevo = NombreUsuariotxt.Text;
            string contraseniaNueva = Contraseniatxt.Text;
            string repetirContrasenia = repetirContraseniatxt.Text;

            if (usuarioBLL.RegistrarUsuario(usuarioNuevo, contraseniaNueva, repetirContrasenia, out string mensaje, "JUGADOR"))
            {
                MessageBox.Show("Usuario creado exitosamente.");
                this.Hide();
                FRMLogin login = new FRMLogin();
                login.Show();
            }
            else
            {
                MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}