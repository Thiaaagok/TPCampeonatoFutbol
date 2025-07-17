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
using TPCampeonatoFutbol.Funciones;
using TPCampeonatoFutbol.Modelos;
using TPCampeonatoFutbol.Servicios;

namespace TPCampeonatoFutbol.Formularios.Campeonato
{
    public partial class Campeonato : Form
    {
        List<CLSEquipo> equipos = new List<CLSEquipo>();
        EquiposService equiposService = new EquiposService();
        public Campeonato()
        {
            InitializeComponent();
            VerificarSiHayCampeonato();
        }

        private void VerificarSiHayCampeonato()
        {
            List<ClSEstadisticasCampeonato> prueba = equiposService.ObtenerEstadisticasCampeonato();
            if(prueba.Count == 0)
            {
                generarCampeonatoBtn.Visible = true;
            }else if(prueba.Count > 0)
            {
                tablaBtn.Visible = true;
                fechasBtn.Visible = true;   
            }
        }

        private void generarCampeonatoBtn_Click(object sender, EventArgs e)
        {
            ObtenerEquipos();
            CLSCampeonato campeonato = new CLSCampeonato();
            List<CLSFecha> fechasGuardar = campeonato.GenerarCampeonato(equipos);

            PartidosService partidoService = new PartidosService();
            FechasService fechaService = new FechasService();

            equiposService.registrarEquiposEstadisticasVacio(equipos);
            int numeroFecha = 1;

            foreach (CLSFecha fecha in fechasGuardar)
            {
                // Asignar fechaId a todos los partidos
                foreach (CLSPartido partido in fecha.Partidos)
                {
                    partido.IdFecha = fecha.Id;
                }

                fechaService.GuardarFecha(fecha, numeroFecha);

                partidoService.GuardarPartidos(fecha.Partidos);

                numeroFecha++;
            }

            MessageBox.Show("Fixture generado y guardado correctamente", "Éxito");
        }
        private void ObtenerEquipos()
        {
            equipos.Clear();

            try
            {
                var listaEquipos = equiposService.ObtenerTodos();
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
    }
}
