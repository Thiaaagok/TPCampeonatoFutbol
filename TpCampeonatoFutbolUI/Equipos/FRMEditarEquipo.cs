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
using TPCampeonatoFutbol.Servicios;
using TpCampeonatoFutbolBE;
using TpCampeonatoFubolBLL;

namespace TPCampeonatoFutbol.Formularios.equipos
{
    public partial class FRMEditarEquipo : Form
    {
        private EquipoBE equipoOriginal = new EquipoBE();
        public EquipoBE equipoEditado { get; private set; }
        //public EquiposBLL equiposBLL { get; private set; }
        //public JugadoresBLL jugadoresBLL { get; private set; }

        public FRMEditarEquipo(EquipoBE equipo)
        {
            InitializeComponent();
            equipoOriginal = equipo;

            //jugadoresBLL = new JugadoresBLL();
            //equiposBLL = new EquiposBLL();

            // Cargar datos en los controles
            nombretxt.Text = equipo.Nombre;
            nombrecortotxt.Text = equipo.NombreCorto;
            ciudadtxt.Text = equipo.Ciudad;
            estadiotxt.Text = equipo.Estadio;
            capacidadEstadioNumber.Value = equipo.CapacidadEstadio;
            anioFundacionNumber.Value = equipo.AnioFundacion;
            obtenerJugadores();
            this.FormBorderStyle = FormBorderStyle.None;
            this.BackColor = Color.FromArgb(39, 57, 80);
            this.StartPosition = FormStartPosition.CenterScreen;
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

            equipoEditado = new EquipoBE(
                equipoOriginal.Id,
                nombretxt.Text,
                nombrecortotxt.Text,
                ciudadtxt.Text,
                estadiotxt.Text,
                (int)capacidadEstadioNumber.Value,
                (int)anioFundacionNumber.Value
            );

            //equiposBLL.editarEquipo(equipoEditado);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void obtenerJugadores()
        {
            equipoOriginal.Jugadores.Clear();

            try
            {
                //List<JugadorBE> jugadores = jugadoresBLL.ObtenerPorEquipoId(equipoOriginal.Id);

                //foreach (var jugador in jugadores)
                //{
                //    var box = this.Controls.Find(jugador.Rol.Codigo + "Box", true).FirstOrDefault();
                //    var label = this.Controls.Find(jugador.Rol.Codigo + "Label", true).FirstOrDefault();

                //    if (box is PictureBox picturebox)
                //    {
                //        Util util = new Util();
                //        util.RemoverEventosClick(picturebox);
                //        picturebox.Image = Properties.Resources.imagenJugador;
                //        picturebox.Click += (sender, e) =>
                //        {
                //            editarJugador(jugador);
                //        };
                //    }

                //    if (label is Label labelControl)
                //    {
                //        labelControl.Text = $"{jugador.Nombre}";
                //        labelControl.TextAlign = ContentAlignment.TopRight;
                //    }

                //    equipoOriginal.Jugadores.Add(jugador);
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar obtener jugadores: " + ex.Message);
            }
        }

        private void nuevoJugador(string posicion)
        {
            FRMCrearJugador crearJugadorForm = new FRMCrearJugador(equipoOriginal,posicion);
            if (crearJugadorForm.ShowDialog() == DialogResult.OK)
            {
                obtenerJugadores();
            }
        }
        private void editarJugador(JugadorBE jugador)
        {
            FRMEditarJugador EditarJugador = new FRMEditarJugador(jugador);
            if (EditarJugador.ShowDialog() == DialogResult.OK)
            {
                obtenerJugadores();
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

        private void cerrarAplicacionBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Hide();
        }

        private void MediocentroDerechoBox_Click_1(object sender, EventArgs e)
        {
            nuevoJugador("MedioCentroDerecho");
        }

    }
}
