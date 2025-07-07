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
        public RegistrarGolFRM(List<CLSEquipo> equiposSeleccionar)
        {
            InitializeComponent();
            equiposCombo.SelectedIndexChanged -= equiposCombo_SelectedIndexChanged;
            equiposCombo.DataSource = equiposSeleccionar;
            equiposCombo.DisplayMember = "Nombre";
            equiposCombo.ValueMember = "Id";
            equiposCombo.SelectedIndex = -1;
            equiposCombo.SelectedIndexChanged += equiposCombo_SelectedIndexChanged;
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

        }
    }
}
