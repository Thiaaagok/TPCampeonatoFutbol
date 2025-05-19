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
    public partial class Equipos : Form
    {
        TableLayoutPanel tableLayoutPanel = new TableLayoutPanel
        {
            Dock = DockStyle.Fill,
            ColumnCount = 3,
            AutoScroll = true,
            BackColor = Color.FromArgb(39, 57, 80),
            Padding = new Padding(20),
        };

        public Equipos()
        {
            InitializeComponent();
            CrearArchivo("equipos.txt");

            for (int i = 0; i < tableLayoutPanel.ColumnCount; i++)
            {
                tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100 / tableLayoutPanel.ColumnCount));
            }

            this.Controls.Add(tableLayoutPanel);

            AgregarEquipos();

            this.FormBorderStyle = FormBorderStyle.None;
            this.BackColor = Color.FromArgb(39, 57, 80);
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        public void AgregarEquipos() {
            tableLayoutPanel.Controls.Clear();
            try
            {
                using (StreamReader sr = new StreamReader("equipos.txt"))
                {
                    string linea;
                    while ((linea = sr.ReadLine()) != null)
                    {
                        string[] partes = linea.Split(',');
                        string nombre = partes[0];
                        string nombreCorto = partes[1];
                        string ciudad = partes[2];
                        string estadio = partes[3];
                        Int32 capacidadEstadio = Convert.ToInt32(partes[4]);
                        Int32 anioFundacion = Convert.ToInt32(partes[5]);
                        Equipo equipo = new Equipo(nombre, nombreCorto, ciudad, estadio, capacidadEstadio, anioFundacion);
                        Panel card2 = AgregarEquipo(equipo);
                        tableLayoutPanel.Controls.Add(card2);
                    }
                }
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Archivo no encontrado");
            }

            Panel card = new Panel
            {
                BackColor = Color.White,
                BorderStyle = BorderStyle.None,
                Size = new Size(250, 100),
                Margin = new Padding(15),
                Padding = new Padding(10),
                Cursor = Cursors.Hand, 
            };

            card.Paint += (sender, e) =>
            {
                ControlPaint.DrawBorder(e.Graphics, card.ClientRectangle,
                    Color.LightGray, 2, ButtonBorderStyle.Solid,
                    Color.LightGray, 2, ButtonBorderStyle.Solid,
                    Color.LightGray, 2, ButtonBorderStyle.Solid,
                    Color.LightGray, 2, ButtonBorderStyle.Solid);
            };

            PictureBox nuevoPictureBox = new PictureBox
            {
                Size = new Size(60, 60),
                SizeMode = PictureBoxSizeMode.Zoom,
                Image = Properties.Resources.nouvelle_icone_grise,
                Cursor = Cursors.Hand
            };


            nuevoPictureBox.Location = new Point(
                (card.Width - nuevoPictureBox.Width) / 2,
                (card.Height - nuevoPictureBox.Height) / 2
            );

            card.Resize += (sender, e) =>
            {
                nuevoPictureBox.Location = new Point(
                    (card.Width - nuevoPictureBox.Width) / 2,
                    (card.Height - nuevoPictureBox.Height) / 2
                );
            };

            card.Click += (sender, e) =>
            {
                crearEquipo();
            };

            nuevoPictureBox.Click += (sender, e) =>
            {
                crearEquipo();
            };

            card.Controls.Add(nuevoPictureBox);
            tableLayoutPanel.Controls.Add(card);
        }

        private Panel AgregarEquipo(Equipo equipo)
        {
            Panel card = new Panel
            {
                BackColor = Color.White,
                BorderStyle = BorderStyle.None,
                Size = new Size(250, 100),
                Margin = new Padding(15), 
                Padding = new Padding(10), 
                Cursor = Cursors.Hand, 
            };

            card.Paint += (sender, e) =>
            {
                ControlPaint.DrawBorder(e.Graphics, card.ClientRectangle,
                    Color.LightGray, 2, ButtonBorderStyle.Solid,
                    Color.LightGray, 2, ButtonBorderStyle.Solid,
                    Color.LightGray, 2, ButtonBorderStyle.Solid,
                    Color.LightGray, 2, ButtonBorderStyle.Solid);
            };

            Label nombreLabel = new Label
            {
                Text = $"{equipo.Nombre} ({equipo.NombreCorto})",
                Font = new Font("Arial", 14, FontStyle.Bold),
                ForeColor = Color.FromArgb(50, 50, 50),
                Dock = DockStyle.Top,
                TextAlign = ContentAlignment.MiddleCenter,
                AutoSize = false,
                Height = 30,
                Margin = new Padding(0, 0, 0, 5),
            };

            Label anioLabel = new Label
            {
                Text = $"Año de fundación: {equipo.AnioFundacion}",
                Font = new Font("Arial", 11, FontStyle.Regular),
                ForeColor = Color.FromArgb(100, 100, 100),
                Dock = DockStyle.Top,
                TextAlign = ContentAlignment.MiddleCenter,
                AutoSize = false,
                Height = 25,
                Margin = new Padding(0, 0, 0, 5),
            };

            Label estadioLabel = new Label
            {
                Text = $"Estadio: {equipo.Estadio}",
                Font = new Font("Arial", 11, FontStyle.Regular),
                ForeColor = Color.FromArgb(100, 100, 100),
                Dock = DockStyle.Top,
                TextAlign = ContentAlignment.MiddleCenter,
                AutoSize = false,
                Height = 25,
            };

            card.Controls.Add(nombreLabel);
            card.Controls.Add(anioLabel);
            card.Controls.Add(estadioLabel);

            return card;
        }

        public void crearEquipo()
        {
            using (var formCrearEquipo = new CrearEquipoForm())
            {
                if (formCrearEquipo.ShowDialog() == DialogResult.OK)
                {
                    if (formCrearEquipo.EquipoCreado != null)
                    {
                        AgregarEquipos();
                    }
                }
            }
        }

        private void CrearArchivo(string RutaArchivo)
        {
            try
            {
                if (!VerificarArchivo(RutaArchivo))
                {
                    using (StreamWriter sw = File.CreateText(RutaArchivo))
                    {
                        sw.WriteLine("Nombre,NombreCorto,Ciudad,Estadio,CapacidadEstadio,AnioFundacion");
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
    }
}
