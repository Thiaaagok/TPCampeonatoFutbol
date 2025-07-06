using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPCampeonatoFutbol.Funciones;
using TPCampeonatoFutbol.Modelos;

namespace TPCampeonatoFutbol.Formularios.Campeonato
{
    public partial class Campeonato : Form
    {
        List<CLSEquipo> equipos = new List<CLSEquipo>();
        public Campeonato()
        {
            InitializeComponent();
            ObtenerEquipos();
        }

        private void generarCampeonatoBtn_Click(object sender, EventArgs e)
        {
            CLSCampeonato campeonato = new CLSCampeonato();
            List<CLSFecha> fechasGuardar = campeonato.GenerarCampeonato(equipos);
            ManejoArchivos manejoArchivos = new ManejoArchivos();
            List<string> fechasLista = new List<string>();
            foreach (CLSFecha fecha in fechasGuardar)
            {
                foreach (CLSPartido partido in fecha.Partidos)
                {
                    partido.IdFecha = fecha.Id;
                    string partidoString = $"{partido.Id},{partido.Local},{partido.Visitante},{partido.IdFecha}";
                    manejoArchivos.GuardarNuevo("partidos.txt", partidoString);
                }
                string linea = $"{fecha.Id},{fecha.Partidos}";
            }
        }

        private void ObtenerEquipos()
        {
            ManejoArchivos manejoArchivos = new ManejoArchivos();
            equipos.Clear();
            try
            {
                List<string> lineas = manejoArchivos.ObtenerTodos("equipos.txt");

                foreach (var linea in lineas)
                {
                    string[] partes = linea.Split(',');
                    CLSEquipo equipo = new CLSEquipo(Guid.Parse(partes[0]), partes[1], partes[2], partes[3], partes[4], int.Parse(partes[5]), int.Parse(partes[6]));
                    equipos.Add(equipo);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar obtener equipos: " + ex.Message);
            }

        }
    }
}
