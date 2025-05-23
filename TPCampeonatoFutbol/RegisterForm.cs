﻿using System;
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
    public partial class RegisterForm : Form
    {
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
        }

        private void Register()
        {
            bool usuarioCorrecto = true;
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
                        if (usuario == NombreUsuariotxt.Text)
                        {
                            usuarioCorrecto = false;
                            MessageBox.Show("El nombre de usuario ingresado ya existe. Intenta con uno diferente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }

                    }
                }

                if (usuarioCorrecto)
                {
                    if(Contraseniatxt.Text == repetirContraseniatxt.Text)
                    {
                        using (StreamWriter sr = new StreamWriter("usuarios.txt"))
                        {
                            sr.WriteLine($"{NombreUsuariotxt.Text},{Contraseniatxt.Text}");
                        }

                        MessageBox.Show("Usuario Creado");
                        this.Hide();
                        LoginForm login = new LoginForm();
                        login.Show();
                    }
                    else
                    {
                        MessageBox.Show("Las contraseñas no coinciden.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Archivo no encontrado");
            }
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

    }
}
