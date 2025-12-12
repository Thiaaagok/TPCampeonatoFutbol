using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Windows.Forms;
using TPCampeonatoFutbol.Servicios;
using TpCampeonatoFutbolBE;
using TpCampeonatoFubolBLL;

namespace TPCampeonatoFutbol.Formularios.Campeonato.Partidos
{
    public partial class AdministrarPartido : Form
    {
        private Label lblTiempo;
        private Timer timer;
        private TimeSpan tiempo;
        private TimeSpan incremento = TimeSpan.FromSeconds(1);
        Guid partidoId = Guid.Empty;
        private System.Windows.Forms.Timer ocultarEventoTimer;
        public List<EquipoBE> equipos = new List<EquipoBE>();
        public List<GolBE> Goles = new List<GolBE>();
        public List<ExpulsionBE> Expulsiones = new List<ExpulsionBE>();
        public Guid equipoLocalId = Guid.Empty;
        public Guid equipoVisitanteId = Guid.Empty;
        public event PartidoRegistradoEvento PartidoRegistrado;
        public AdministrarPartido(Guid localId,Guid visitanteId,Guid partidoId)
        {
            InitializeComponent();
            equipoLocalId = localId;
            equipoVisitanteId = visitanteId;
            lblTiempo = new Label { Text = "00:00:00", AutoSize = true, Font = new System.Drawing.Font("Arial", 24F), Location = new System.Drawing.Point(300, 10), ForeColor = Color.White };
            this.Controls.Add(lblTiempo);
            timer = new Timer();
            timer.Interval = 1000; 
            timer.Tick += Timer_Tick;
            this.FormBorderStyle = FormBorderStyle.None;
            this.BackColor = Color.FromArgb(39, 57, 80);
            this.StartPosition = FormStartPosition.CenterScreen;

            tiempo = TimeSpan.Zero;
            this.StartPosition = FormStartPosition.CenterScreen;
            obtenerEquiposPartido(localId, visitanteId);

            this.partidoId = partidoId;
        }
        private void obtenerEquiposPartido(Guid localId, Guid visitanteId)
        {
            //var servicio = new EquiposBLL();
            //EquipoBE equipoLocal = servicio.ObtenerEquipoPorId(localId);
            //EquipoBE equipoVisitante = servicio.ObtenerEquipoPorId(visitanteId);
            //equipos.Add(equipoLocal);
            //equipos.Add(equipoVisitante);
            //nombreCortoLocal.Text = equipoLocal.NombreCorto;
            //nombreCortoVisitante.Text = equipoVisitante.NombreCorto;
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
            //    SoundPlayer player = new SoundPlayer(Properties.Resources.Sonido_de_gol);
            //    player.Play();
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
            //    SoundPlayer player = new SoundPlayer(Properties.Resources.Sonido_de_expusion);
            //    player.Play();
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
            ocultarEventoTimer.Interval = 10000; 
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
            //using (RegistrarGolFRM registrarGolFRM = new RegistrarGolFRM(equipos,partidoId, tiempo.Minutes))
            //{
            //    var result = registrarGolFRM.ShowDialog();
            //    if (result == DialogResult.OK)
            //    {
            //        GolBE golCreado = registrarGolFRM.GolCreado;
            //        Goles.Add(golCreado);
            //        if(golCreado.EquipoId == equipoLocalId)
            //        {
            //            int goles = int.Parse(golesLocal.Text);
            //            goles += 1;
            //            golesLocal.Text = goles.ToString();
            //        }
            //        else if(golCreado.EquipoId == equipoVisitanteId) 
            //        {
            //            int goles = int.Parse(golesLocal.Text);
            //            goles += 1;
            //            golesVisitante.Text = goles.ToString();
            //        }
            //        registroEventosList.Items.Add($"Gol: {golCreado.Autor}, Minuto: {golCreado.Minutos}");
            //        MostrarEvento("GOOOLLL!!!", golCreado.Autor);
            //    }
            //}
        }

        private void eventoExpulsionBtn_Click(object sender, EventArgs e)
        {
            //using (RegistrarExpulsionFRM registrarExpulsionFRM = new RegistrarExpulsionFRM(equipos, partidoId, tiempo.Minutes ))
            //{
            //    var result = registrarExpulsionFRM.ShowDialog();
            //    if (result == DialogResult.OK)
            //    {
            //        ExpulsionBE nuevaExpulsion = registrarExpulsionFRM.ExpulsionCreada;
            //        Expulsiones.Add(nuevaExpulsion);
            //        registroEventosList.Items.Add($"Expulsión: {nuevaExpulsion.Autor}, Minuto: {nuevaExpulsion.Minutos}");
            //        MostrarEvento("EXPULSIÓN", nuevaExpulsion.Autor);
            //    }
            //}
        }

        private void ReproducirSonidoEvento(string tipoEvento)
        {
            if (tipoEvento == "GOOOLLL!!!")
                ReproducirGol();
            else if (tipoEvento == "EXPULSIÓN")
                ReproducirExpulsion();
        }

        private void registrarPartidoBtn_Click(object sender, EventArgs e)
        {
            //PartidosBLL partidoService = new PartidosBLL();
            //EquiposBLL equiposService = new EquiposBLL();
            //partidoService.RegistrarGoles(Goles);
            //partidoService.RegistrarExpulsiones(Expulsiones);
            int golesLocal = Goles.Count(g => g.EquipoId == equipoLocalId);
            int golesVisitante = Goles.Count(g => g.EquipoId == equipoVisitanteId);
            //int expulsionesLocal = Expulsiones.Count(exp => exp.EquipoId == equipoLocalId);
            //int expulsionesVisitante = Expulsiones.Count(exp => exp.EquipoId == equipoVisitanteId);
            //partidoService.RegistrarPartido(partidoId, golesLocal, golesVisitante, expulsionesLocal, expulsionesVisitante);
            //if(golesLocal > golesVisitante)
            //{
            //    equiposService.registrarPartidoEquipo(equipoLocalId,"GANADO", golesLocal, expulsionesLocal);
            //    equiposService.registrarPartidoEquipo(equipoVisitanteId, "PERDIDO", golesVisitante, expulsionesVisitante);
            //}
            //else if(golesVisitante > golesLocal)
            //{
            //    equiposService.registrarPartidoEquipo(equipoVisitanteId, "GANADO", golesVisitante, expulsionesVisitante);
            //    equiposService.registrarPartidoEquipo(equipoLocalId, "PERDIDO", golesLocal, expulsionesLocal);
            //}
            //else if(golesLocal == golesVisitante)
            //{
            //    equiposService.registrarPartidoEquipo(equipoVisitanteId, "EMPATADO", golesVisitante, expulsionesVisitante);
            //    equiposService.registrarPartidoEquipo(equipoLocalId, "EMPATADO", golesLocal, expulsionesLocal);
            //}
            PartidoRegistrado?.Invoke("Partido registrado correctamente.");
            this.Close();
        }
    }

    public delegate void PartidoRegistradoEvento(string mensaje);

}
