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
    public partial class CrearEquipoForm : Form
    {

        public CrearEquipoForm()
        {
            InitializeComponent();

            // Configurar el formulario
            this.Text = "Crear Nuevo Equipo";
            this.Size = new System.Drawing.Size(400, 300);

            // Crear y agregar controles
            var labelNombre = new Label { Text = "Nombre:", Top = 20, Left = 20, Width = 100 };
            var textNombre = new TextBox { Top = 20, Left = 130, Width = 200 };

            var labelNombreCorto = new Label { Text = "Nombre Corto:", Top = 60, Left = 20, Width = 100 };
            var textNombreCorto = new TextBox { Top = 60, Left = 130, Width = 200 };

            var labelAnioFundacion = new Label { Text = "Año de Fundación:", Top = 100, Left = 20, Width = 100 };
            var textAnioFundacion = new NumericUpDown { Top = 100, Left = 130, Width = 200 };

            var labelEstadio = new Label { Text = "Estadio:", Top = 140, Left = 20, Width = 100 };
            var textEstadio = new TextBox { Top = 140, Left = 130, Width = 200 };

            var btnCrear = new Button { Text = "Crear", Top = 200, Left = 130, Width = 100 };
            btnCrear.Click += (sender, e) =>
            {
                if (string.IsNullOrWhiteSpace(textNombre.Text) ||
                    string.IsNullOrWhiteSpace(textNombreCorto.Text) ||
                    string.IsNullOrWhiteSpace(textAnioFundacion.Text) ||
                    string.IsNullOrWhiteSpace(textEstadio.Text)) 
                {
                    MessageBox.Show("Por favor, completa todos los campos correctamente.");
                    return;
                }

                Int32 anio = Convert.ToInt32(textAnioFundacion.Text);
                EquipoCreado = new Equipo(
                    textNombre.Text,
                    textNombreCorto.Text,
                    "Ciudad",
                    textEstadio.Text,
                    50000,
                    anio);
                using (StreamWriter sr = new StreamWriter("equipos.txt", append: true))
                {
                    sr.WriteLine($"{EquipoCreado.Nombre},{EquipoCreado.NombreCorto},{EquipoCreado.Ciudad},{EquipoCreado.Estadio},{EquipoCreado.CapacidadEstadio},{EquipoCreado.AnioFundacion}");
                }
                this.DialogResult = DialogResult.OK; 
                this.Close();
            };

            this.Controls.Add(labelNombre);
            this.Controls.Add(textNombre);
            this.Controls.Add(labelNombreCorto);
            this.Controls.Add(textNombreCorto);
            this.Controls.Add(labelAnioFundacion);
            this.Controls.Add(textAnioFundacion);
            this.Controls.Add(labelEstadio);
            this.Controls.Add(textEstadio);
            this.Controls.Add(btnCrear);
        }

        public Equipo EquipoCreado { get; private set; }
    }
}
