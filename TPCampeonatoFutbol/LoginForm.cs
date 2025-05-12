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

namespace TPCampeonatoFutbol
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            AsignarDiseños();
            CrearArchivo("usuarios.txt");
        }

        private void AsignarDiseños()
        {
            // diseño formulari
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

            //diseño iniciar sesión boton
            IniciarSesionbtn.BackColor = Color.FromArgb(33, 53, 73);
            IniciarSesionbtn.FlatStyle = FlatStyle.Flat;
            IniciarSesionbtn.FlatAppearance.BorderColor = Color.FromArgb(85, 159, 127);
            IniciarSesionbtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(20, 20, 20);
            IniciarSesionbtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(70, 118, 126);
            IniciarSesionbtn.ForeColor = Color.LightGray;
            IniciarSesionbtn.Size = new Size(408, 40);

            //diseño crear cuenta boton
            crearCuentaBtn.BackColor = Color.FromArgb(33, 53, 73);
            crearCuentaBtn.FlatStyle = FlatStyle.Flat;
            crearCuentaBtn.FlatAppearance.BorderColor = Color.FromArgb(85, 159, 127);
            crearCuentaBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(20, 20, 20);
            crearCuentaBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(70, 118, 126);
            crearCuentaBtn.ForeColor = Color.LightGray;
            crearCuentaBtn.Size = new Size(208, 40);
        }

        private void Login()
        {
            bool loginCorrecto = false;
            try
            {
                using (StreamReader sr = new StreamReader("usuarios.txt"))
                {
                    string linea;
                    while ((linea = sr.ReadLine()) != null)
                    {
                        string[] partes = linea.Split(',');
                        string usuario = partes[0];
                        string contrasenia = partes[1];
                        if (usuario == NombreUsuariotxt.Text && contrasenia == Contraseniatxt.Text)
                        {
                            loginCorrecto = true;
                            this.Hide();
                            Form1 form1 = new Form1();
                            form1.Show();
                            break;
                        }

                    }
                    if (!loginCorrecto)
                    {
                        MessageBox.Show("Usuario o Contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Archivo no encontrado");
            }
        }

        private void IniciarSesionbtn_Click(object sender, EventArgs e)
        {
            if (NombreUsuariotxt.Text != "" && Contraseniatxt.Text != "")
            {
                Login();
            }
            else
            {
                MessageBox.Show("Por favor, completar los campos correctamente");
            }
        }

        private void CrearArchivo(string RutaArchivo)
        {
            try
            {
                if (!VerificarArchivo(RutaArchivo))
                {
                    using (File.CreateText(RutaArchivo))
                    {

                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private bool VerificarArchivo(string RutaArchivo)
        {
            return File.Exists(RutaArchivo);
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            labelDummy.Focus();
        }

        private void crearCuentaBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
        }
    }
}
