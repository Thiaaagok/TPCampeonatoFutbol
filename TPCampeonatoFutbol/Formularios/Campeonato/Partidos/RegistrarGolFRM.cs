using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPCampeonatoFutbol.Servicios;

namespace TPCampeonatoFutbol.Formularios.Campeonato.Partidos
{
    public partial class RegistrarGolFRM : Form
    {
        public JugadoresService jugadoresService = new JugadoresService();
        public CLSGolesEquipo GolCreado = new CLSGolesEquipo();
        Guid partidoId = Guid.Empty;
        int minutos = 0;
        public RegistrarGolFRM(List<CLSEquipo> equiposSeleccionar, Guid partidoId, int minutos)
        {
            InitializeComponent();
            this.partidoId = partidoId;
            equiposCombo.SelectedIndexChanged -= equiposCombo_SelectedIndexChanged;
            equiposCombo.DataSource = equiposSeleccionar;
            equiposCombo.DisplayMember = "Nombre";
            equiposCombo.ValueMember = "Id";
            equiposCombo.SelectedIndex = -1;
            equiposCombo.SelectedIndexChanged += equiposCombo_SelectedIndexChanged;
            this.minutos = minutos;
        }

        public void obtenerJugadoresCombo(Guid equipoId)
        {
            jugadoresCombo.DataSource = jugadoresService.ObtenerPorEquipoId(equipoId);
            jugadoresCombo.DisplayMember = "Nombre";
            jugadoresCombo.ValueMember = "Id";
            jugadoresCombo.SelectedIndex = -1;
            jugadoresCombo.Text = "";
        }

        private void equiposCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (equiposCombo.SelectedIndex != -1)
            {
                CLSEquipo equipoSeleccionado = (CLSEquipo)equiposCombo.SelectedItem;
                obtenerJugadoresCombo(equipoSeleccionado.Id);
            }
        }

        private void registrarGolBtn_Click(object sender, EventArgs e)
        {
            if (equiposCombo.SelectedItem is CLSEquipo equipoSeleccionado &&
                jugadoresCombo.SelectedItem is CLSJugador jugadorSeleccionado)
            {
                Guid equipoId = equipoSeleccionado.Id;
                Guid jugadorId = jugadorSeleccionado.Id;

                GolCreado = new CLSGolesEquipo(partidoId, equipoId, jugadorId, jugadorSeleccionado.Nombre,equipoId,minutos);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un equipo y un jugador.");
            }
        }
    }
}
