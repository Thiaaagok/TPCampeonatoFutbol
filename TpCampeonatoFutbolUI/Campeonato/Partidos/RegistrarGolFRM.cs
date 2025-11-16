using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TpCampeonatoFubolBLL;
using TPCampeonatoFutbol.Servicios;
using TpCampeonatoFutbolBE;

namespace TPCampeonatoFutbol.Formularios.Campeonato.Partidos
{
    public partial class RegistrarGolFRM : Form
    {
        public JugadoresBLL jugadoresBLL = new JugadoresBLL();
        public GolBE GolCreado = new GolBE();
        Guid partidoId = Guid.Empty;
        int minutos = 0;
        public RegistrarGolFRM(List<EquipoBE> equiposSeleccionar, Guid partidoId, int minutos)
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
            jugadoresCombo.DataSource = jugadoresBLL.ObtenerPorEquipoId(equipoId);
            jugadoresCombo.DisplayMember = "Nombre";
            jugadoresCombo.ValueMember = "Id";
            jugadoresCombo.SelectedIndex = -1;
            jugadoresCombo.Text = "";
        }

        private void equiposCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (equiposCombo.SelectedIndex != -1)
            {
                EquipoBE equipoSeleccionado = (EquipoBE)equiposCombo.SelectedItem;
                obtenerJugadoresCombo(equipoSeleccionado.Id);
            }
        }

        private void registrarGolBtn_Click(object sender, EventArgs e)
        {
            if (equiposCombo.SelectedItem is EquipoBE equipoSeleccionado &&
                jugadoresCombo.SelectedItem is JugadorBE jugadorSeleccionado)
            {
                Guid equipoId = equipoSeleccionado.Id;
                Guid jugadorId = jugadorSeleccionado.Id;

                GolCreado = new GolBE(partidoId, equipoId, jugadorId,equipoId);
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
