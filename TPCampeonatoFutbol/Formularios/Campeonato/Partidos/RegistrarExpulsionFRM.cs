﻿using System;
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
    public partial class RegistrarExpulsionFRM : Form
    {
        public JugadoresService jugadoresService = new JugadoresService();
        public Guid partidoId = Guid.Empty;
        int minutos = 0;
        public CLSExpulsion ExpulsionCreada { get; private set; }
        public RegistrarExpulsionFRM(List<CLSEquipo> equiposSeleccionar, Guid partidoId,int minutos)
        {
            InitializeComponent();
            this.partidoId = partidoId;
            this.minutos = minutos;
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

        private void registrarExpulsionBtn_Click(object sender, EventArgs e)
        {
            if (equiposCombo.SelectedItem is CLSEquipo equipoSeleccionado &&
                jugadoresCombo.SelectedItem is CLSJugador jugadorSeleccionado)
            {
                Guid equipoId = equipoSeleccionado.Id;
                Guid jugadorId = jugadorSeleccionado.Id;

                ExpulsionCreada = new CLSExpulsion(partidoId, equipoId, jugadorId, jugadorSeleccionado.Nombre, minutos,causasCombo.Text);
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
