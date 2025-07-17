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
using TPCampeonatoFutbol.Servicios;

namespace TPCampeonatoFutbol.Formularios.jugadores
{
    public partial class FRMCrearJugador : Form
    {
        CLSEquipo equipo = new CLSEquipo();
        CLSRol rolSeleccionado = new CLSRol();
        private readonly JugadoresService jugadoresService = new JugadoresService();
        public FRMCrearJugador(CLSEquipo equipo,string rolDescripcion)
        {
            InitializeComponent();
            this.equipo = equipo;
            rolSeleccionado = CLSRol.ObtenerRoles()
            .FirstOrDefault(r => r.Codigo == rolDescripcion);
            this.FormBorderStyle = FormBorderStyle.None;
            this.BackColor = Color.FromArgb(39, 57, 80);
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        public CLSJugador NuevoJugador { get; private set; }

        private void crearJugadorBtn_Click(object sender, EventArgs e)
        {
            string mensaje;
            CLSJugador jugador;

            bool creado = jugadoresService.CrearJugador(
                nombretxt.Text,
                apellidotxt.Text,
                Convert.ToInt32(edadNumeric.Value),
                Convert.ToInt32(dniNumeric.Value),
                fechaNacimiento.Value,
                lugarNacimientotxt.Text,
                equipo.Id,
                rolSeleccionado,
                out mensaje,
                out jugador
            );

            if (!creado)
            {
                MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            NuevoJugador = jugador;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void cerrarAplicacionBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
