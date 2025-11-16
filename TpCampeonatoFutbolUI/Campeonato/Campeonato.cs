using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPCampeonatoFutbol.Formularios.Campeonato.Tabla;
using TPCampeonatoFutbol.Servicios;
using TpCampeonatoFutbolBE;
using TpCampeonatoFubolBLL;

namespace TPCampeonatoFutbol.Formularios.Campeonato
{
    public partial class Campeonato : Form
    {
        List<EquipoBE> equipos = new List<EquipoBE>();
        EquiposBLL equiposBLL = new EquiposBLL();
        public Campeonato()
        {
            InitializeComponent();
            VerificarSiHayCampeonato();
            this.FormBorderStyle = FormBorderStyle.None;
            this.BackColor = Color.FromArgb(39, 57, 80);
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void VerificarSiHayCampeonato()
        {
            List<EstadisticasCampeonatoBE> prueba = equiposBLL.ObtenerEstadisticasCampeonato();
            if(prueba.Count == 0)
            {
                //if(UsuarioGlobal.Instancia.Rol == "ORGANIZADOR" || UsuarioGlobal.Instancia.Rol == "ADMIN")
                //{
                //    generarCampeonatoBtn.Visible = true;
                //}
                //else
                //{
                //    this.Close();
                //}
            }else if(prueba.Count > 0)
            {
                tablaBtn.Visible = true;
                fechasBtn.Visible = true;   
            }
        }

        private void generarCampeonatoBtn_Click(object sender, EventArgs e)
        {
            ObtenerEquipos();
            CampeonatoBE campeonatoBE = new CampeonatoBE();
            List<FechaBE> fechasGuardar = campeonatoBE.GenerarCampeonato(equipos);

            PartidosBLL partidosBLL = new PartidosBLL();
            FechasBLL fechasBLL = new FechasBLL();

            equiposBLL.registrarEquiposEstadisticasVacio(equipos);
            int numeroFecha = 1;

            foreach (FechaBE fecha in fechasGuardar)
            {
                // Asignar fechaId a todos los partidos
                foreach (PartidoBE partido in fecha.Partidos)
                {
                    partido.IdFecha = fecha.Id;
                }

                fechasBLL.GuardarFecha(fecha, numeroFecha);

                partidosBLL.GuardarPartidos(fecha.Partidos);

                numeroFecha++;
            }

            MessageBox.Show("Fixture generado y guardado correctamente", "Éxito");
        }
        private void ObtenerEquipos()
        {
            equipos.Clear();

            try
            {
                var listaEquipos = equiposBLL.ObtenerTodos();
                equipos.AddRange(listaEquipos);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "ERROR", MessageBoxButtons.OK);
            }
        }

        private void fechasBtn_Click(object sender, EventArgs e)
        {
            Fechas fechas = new Fechas();
            fechas.Show();
        }

        private void tablaBtn_Click(object sender, EventArgs e)
        {
            TablaFRM tablaFRM = new TablaFRM();
            tablaFRM.Show();
        }

        private void volverBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Campeonato_Load(object sender, EventArgs e)
        {

        }
    }
}
