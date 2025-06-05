using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPCampeonatoFutbol.Formularios.jugadores;

namespace TPCampeonatoFutbol.Formularios.equipos
{
    public partial class EditarEquipoForm : Form
    {
        private Equipo equipoOriginal = new Equipo();
        public Equipo EquipoEditado { get; private set; }

        public EditarEquipoForm(Equipo equipo)
        {
            InitializeComponent();
            equipoOriginal = equipo;

            // Cargar datos en los controles
            nombretxt.Text = equipo.Nombre;
            nombrecortotxt.Text = equipo.NombreCorto;
            ciudadtxt.Text = equipo.Ciudad;
            estadiotxt.Text = equipo.Estadio;
            capacidadEstadioNumber.Value = equipo.CapacidadEstadio;
            anioFundacionNumber.Value = equipo.AnioFundacion;
        }

        private void editarEquipoBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nombretxt.Text) ||
                string.IsNullOrWhiteSpace(nombrecortotxt.Text) ||
                anioFundacionNumber.Value <= 0 ||
                string.IsNullOrWhiteSpace(estadiotxt.Text) ||
                capacidadEstadioNumber.Value <= 0)
            {
                MessageBox.Show("Por favor, completa todos los campos correctamente.");
                return;
            }

            EquipoEditado = new Equipo(
                nombretxt.Text,
                nombrecortotxt.Text,
                ciudadtxt.Text,
                estadiotxt.Text,
                (int)capacidadEstadioNumber.Value,
                (int)anioFundacionNumber.Value
            );

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void nuevoJugador(string posicion)
        {
            CrearJugadorForm crearJugadorForm = new CrearJugadorForm(equipoOriginal,posicion);
            if (crearJugadorForm.ShowDialog() == DialogResult.OK)
            {
                var nuevoJugador = crearJugadorForm.NuevoJugador;
                var box = this.Controls.Find(nuevoJugador.Rol.Descripcion + "Box", true).FirstOrDefault();
                var label = this.Controls.Find(nuevoJugador.Rol.Descripcion + "Label", true).FirstOrDefault();

                if (box is PictureBox picturebox)
                {
                    picturebox.Image = Properties.Resources.imagenJugador;
                }

                if (label is Label labelControl)
                {
                    labelControl.Text = $"{nuevoJugador.Nombre}";
                }
            }
        }

        private void EditarEquipoForm_Load(object sender, EventArgs e)
        {

        }

        private void delanteroBox_Click(object sender, EventArgs e)
        {
            nuevoJugador("Delantero");
        }

        private void ExtremoIzquierdoBox_Click(object sender, EventArgs e)
        {
            nuevoJugador("ExtremoIzquierdo");
        }

        private void ExtremoDerechoBox_Click(object sender, EventArgs e)
        {
            nuevoJugador("ExtremoDerecho");
        }

        private void MediocentroIzquierdoBox_Click(object sender, EventArgs e)
        {
            nuevoJugador("MediocentroIzquierdo");
        }

        private void MediocentroBox_Click(object sender, EventArgs e)
        {
            nuevoJugador("Mediocentro");
        }

        private void MediocentroDerechoBox_Click(object sender, EventArgs e)
        {
            nuevoJugador("MediocentroDerecho");
        }

        private void LateralIzquierdoBox_Click(object sender, EventArgs e)
        {
            nuevoJugador("LateralIzquierdo");
        }

        private void DefensacentralIzquierdaBox_Click(object sender, EventArgs e)
        {
            nuevoJugador("DefensacentralIzquierdo");
        }

        private void DefensacentralDerechoBox_Click(object sender, EventArgs e)
        {
            nuevoJugador("DefensacentralDerecho");
        }

        private void LateralDerechoBox_Click(object sender, EventArgs e)
        {
            nuevoJugador("LateralDerecho");
        }

        private void ArqueroBox_Click(object sender, EventArgs e)
        {
            nuevoJugador("Arquero");
        }

        private void Suplente1Box_Click(object sender, EventArgs e)
        {
            nuevoJugador("Suplente1");
        }

        private void Suplente2Box_Click(object sender, EventArgs e)
        {
            nuevoJugador("Suplente2");
        }

        private void Suplente3Box_Click(object sender, EventArgs e)
        {
            nuevoJugador("Suplente3");
        }

        private void Suplente4Box_Click(object sender, EventArgs e)
        {
            nuevoJugador("Suplente4");
        }

        private void Suplente5Box_Click(object sender, EventArgs e)
        {
            nuevoJugador("Suplente5");
        }

    }
}
