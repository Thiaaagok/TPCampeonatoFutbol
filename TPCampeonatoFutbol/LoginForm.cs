using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

            this.FormBorderStyle = FormBorderStyle.None;
            this.BackColor = Color.FromArgb(39, 57, 80);
            this.StartPosition = FormStartPosition.CenterScreen;

            NombreUsuariotxt.TabStop = false;
            NombreUsuariotxt.BackColor = Color.FromArgb(39, 57, 80);
            NombreUsuariotxt.BorderStyle = BorderStyle.None;
            NombreUsuariotxt.Font = new Font("Century Gothic", 12F);
            NombreUsuariotxt.ForeColor = Color.Silver;
            NombreUsuariotxt.Size = new Size(408, 30);

            Contraseniatxt.TabStop = false;
            Contraseniatxt.BackColor = Color.FromArgb(39, 57, 80);
            Contraseniatxt.BorderStyle = BorderStyle.None;
            Contraseniatxt.Font = new Font("Century Gothic", 12F);
            Contraseniatxt.ForeColor = Color.Silver;
            Contraseniatxt.Size = new Size(408, 30);

            IniciarSesionbtn.BackColor = Color.FromArgb(33, 53, 73);
            IniciarSesionbtn.FlatStyle = FlatStyle.Flat;
            IniciarSesionbtn.FlatAppearance.BorderColor = Color.FromArgb(85, 159, 127);
            IniciarSesionbtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(20, 20, 20);
            IniciarSesionbtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(70, 118, 126);
            IniciarSesionbtn.ForeColor = Color.LightGray;
            IniciarSesionbtn.Size = new Size(408, 40);

            crearCuentaBtn.BackColor = Color.FromArgb(33, 53, 73);
            crearCuentaBtn.FlatStyle = FlatStyle.Flat;
            crearCuentaBtn.FlatAppearance.BorderColor = Color.FromArgb(85, 159, 127);
            crearCuentaBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(20, 20, 20);
            crearCuentaBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(70, 118, 126);
            crearCuentaBtn.ForeColor = Color.LightGray;
            crearCuentaBtn.Size = new Size(208, 40);
        }

        private void NombreUsuariotxt_Enter(object sender, EventArgs e)
        {
            if (NombreUsuariotxt.Text == "Usuario")
            {
                NombreUsuariotxt.Text = "";
                NombreUsuariotxt.ForeColor = Color.LightGray;
            }
        }

        private void NombreUsuariotxt_Leave(object sender, EventArgs e)
        {
            if (NombreUsuariotxt.Text == "")
            {
                NombreUsuariotxt.Text = "Usuario";
                NombreUsuariotxt.ForeColor = Color.Silver;
            }
        }

        private void Contraseniatxt_Enter(object sender, EventArgs e)
        {
            if (Contraseniatxt.Text == "Contraseña")
            {
                Contraseniatxt.Text = "";
                Contraseniatxt.ForeColor = Color.LightGray;
                Contraseniatxt.UseSystemPasswordChar = true;
            }
        }

        private void Contraseniatxt_Leave(object sender, EventArgs e)
        {
            if (Contraseniatxt.Text == "")
            {
                Contraseniatxt.Text = "Contraseña";
                Contraseniatxt.ForeColor = Color.Silver;
                Contraseniatxt.UseSystemPasswordChar = false;
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            labelDummy.Focus();
        }

    }
}
