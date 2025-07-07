using System;
using System.Collections.Generic;
using System.IO;
using System.Media;
using System.Windows.Forms;
using NAudio.Wave;
using TPCampeonatoFutbol.Servicios;

namespace TPCampeonatoFutbol.Formularios.Campeonato.Partidos
{
    public partial class AdministrarPartido : Form
    {
        private Label lblTiempo;
        private Timer timer;
        private TimeSpan tiempo;
        private TimeSpan incremento = TimeSpan.FromSeconds(1);
        private System.Windows.Forms.Timer ocultarEventoTimer;
        public List<CLSEquipo> equipos = new List<CLSEquipo>();

        public AdministrarPartido(Guid localId,Guid visitanteId)
        {
            InitializeComponent();
            lblTiempo = new Label { Text = "00:00:00", AutoSize = true, Font = new System.Drawing.Font("Arial", 24F), Location = new System.Drawing.Point(300, 10) };
            this.Controls.Add(lblTiempo);
            timer = new Timer();
            timer.Interval = 1000; 
            timer.Tick += Timer_Tick;

            tiempo = TimeSpan.Zero;
            this.StartPosition = FormStartPosition.CenterScreen;
            obtenerEquiposPartido(localId, visitanteId);
        }
        private void obtenerEquiposPartido(Guid localId, Guid visitanteId)
        {
            var servicio = new EquiposService();
            CLSEquipo equipoLocal = servicio.ObtenerEquipoPorId(localId);
            CLSEquipo equipoVisitante = servicio.ObtenerEquipoPorId(visitanteId);
            equipos.Add(equipoLocal);
            equipos.Add(equipoVisitante);
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            tiempo = tiempo.Add(incremento);

            int minutosTotales = (int)tiempo.TotalMinutes;
            int segundosRestantes = tiempo.Seconds;

            lblTiempo.Text = tiempo.ToString(@"hh\:mm\:ss");

            if (minutosTotales >= 90)
            {
                timer.Stop();
                MessageBox.Show("¡Final del partido!");
            }

        }

        private void acelerar10segundosBtn_Click(object sender, EventArgs e)
        {
            incremento = TimeSpan.FromSeconds(10);
        }

        private void acelerar30segundosBtn_Click(object sender, EventArgs e)
        {
            incremento = TimeSpan.FromSeconds(30);
        }

        private void acelerar1minutoBtn_Click(object sender, EventArgs e)
        {
            incremento = TimeSpan.FromMinutes(1);
        }

        private void desacelerarBtn_Click(object sender, EventArgs e)
        {
            incremento = TimeSpan.FromSeconds(1);
        }

        private void PausarCronometroBTN_Click_1(object sender, EventArgs e)
        {
            timer.Stop();
        }

        private void iniciarCronometroBtn_Click_1(object sender, EventArgs e)
        {
            timer.Start();
        }
        public void ReproducirGol()
        {
            try
            {
                SoundPlayer player = new SoundPlayer(Properties.Resources.Sonido_de_gol);
                player.Play();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al reproducir el audio: " + ex.Message);
            }
        }

        public void ReproducirExpulsion()
        {
            try
            {
                SoundPlayer player = new SoundPlayer(Properties.Resources.Sonido_de_expusion);
                player.Play();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al reproducir el audio: " + ex.Message);
            }
        }

        private void MostrarEvento(string titulo, string jugador)
        {
            ReproducirSonidoEvento(titulo);

            timer.Stop();

            EventoTitulo.Text = titulo;
            EventoTitulo.Visible = true;

            jugadorEvento.Text = jugador;
            jugadorEvento.Visible = true;

            tiempoEvento.Text = tiempo.ToString(@"hh\:mm\:ss");
            tiempoEvento.Visible = true;

            if (ocultarEventoTimer != null)
            {
                ocultarEventoTimer.Stop();
                ocultarEventoTimer.Tick -= OcultarEventoTimer_Tick;
            }

            ocultarEventoTimer = new System.Windows.Forms.Timer();
            ocultarEventoTimer.Interval = 10000; // 10 segundos
            ocultarEventoTimer.Tick += OcultarEventoTimer_Tick;
            ocultarEventoTimer.Start();
        }

        private void OcultarEventoTimer_Tick(object sender, EventArgs e)
        {
            EventoTitulo.Visible = false;
            jugadorEvento.Visible = false;
            tiempoEvento.Visible = false;

            ocultarEventoTimer.Stop();
            ocultarEventoTimer.Tick -= OcultarEventoTimer_Tick;
            ocultarEventoTimer = null;

            timer.Start(); 
        }

        private void eventoGolBtn_Click(object sender, EventArgs e)
        {
            using (RegistrarGolFRM registrarGolFRM = new RegistrarGolFRM(equipos))
            {
                var result = registrarGolFRM.ShowDialog();
                if (result == DialogResult.OK)
                {
                    MostrarEvento("GOOOLLL!!!", "Thiago");
                }
            }
        }

        private void eventoExpulsionBtn_Click(object sender, EventArgs e)
        {
            using (RegistrarExpulsionFRM registrarExpulsionFRM = new RegistrarExpulsionFRM(equipos))
            {
                var result = registrarExpulsionFRM.ShowDialog();
                if (result == DialogResult.OK)
                {
                    MostrarEvento("EXPULSIÓN", "Thiago");
                }
            }
        }

        private void ReproducirSonidoEvento(string tipoEvento)
        {
            if (tipoEvento == "GOOOLLL!!!")
                ReproducirGol();
            else if (tipoEvento == "EXPULSIÓN")
                ReproducirExpulsion();
        }
    }
}
