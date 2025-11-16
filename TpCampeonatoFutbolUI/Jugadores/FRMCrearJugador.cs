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
using TpCampeonatoFutbolBE;
using TpCampeonatoFubolBLL;

namespace TPCampeonatoFutbol.Formularios.jugadores
{
    public partial class FRMCrearJugador : Form
    {
        EquipoBE equipoBE = new EquipoBE();
        RolBE rolSeleccionado = new RolBE();
        private readonly JugadoresBLL jugadoresBLL = new JugadoresBLL();
        public FRMCrearJugador(EquipoBE equipoBE,string rolDescripcion)
        {
            InitializeComponent();
            this.equipoBE = equipoBE;
            rolSeleccionado = RolBE.ObtenerRoles()
            .FirstOrDefault(r => r.Codigo == rolDescripcion);
            this.FormBorderStyle = FormBorderStyle.None;
            this.BackColor = Color.FromArgb(39, 57, 80);
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        public JugadorBE NuevoJugador { get; private set; }

        private void crearJugadorBtn_Click(object sender, EventArgs e)
        {
            string mensaje;
            JugadorBE jugador;

            bool creado = jugadoresBLL.CrearJugador(
                nombretxt.Text,
                apellidotxt.Text,
                Convert.ToInt32(edadNumeric.Value),
                Convert.ToInt32(dniNumeric.Value),
                fechaNacimiento.Value,
                lugarNacimientotxt.Text,
                equipoBE.Id,
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
