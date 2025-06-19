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
    public partial class Fechas : Form
    {
        List<CLSFecha> fechas = new List<CLSFecha>();
        ManejoArchivos manejoArchivos = new ManejoArchivos();
        public Fechas()
        {
            InitializeComponent();
        }

        public void ObtenerFechas()
        {
            fechas.Clear();
            try
            {
                List<string> lineas = manejoArchivos.ObtenerTodos("equipos.txt");

                //foreach (var linea in lineas)
                //{
                //    string[] partes = linea.Split(',');
                //    CLSFecha equipo = new CLSFecha(partes[0], partes[1], partes[2], partes[3], partes[4], Convert.ToInt32(partes[5]), Convert.ToInt32(partes[6]));
                //    fechas.Add(equipo);
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar obtener equipos: " + ex.Message);
            }
        }
    }
}
