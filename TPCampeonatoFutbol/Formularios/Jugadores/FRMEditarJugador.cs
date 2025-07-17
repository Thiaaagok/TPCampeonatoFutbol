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

namespace TPCampeonatoFutbol.Formularios.jugadores
{
    public partial class FRMEditarJugador : Form
    {
        private CLSJugador jugadorEditar;
        private readonly JugadoresService jugadoresService = new JugadoresService();

        public FRMEditarJugador(CLSJugador jugador)
        {
            InitializeComponent();
            jugadorEditar = jugador;
            SetearPropiedades();
            this.FormBorderStyle = FormBorderStyle.None;
            this.BackColor = Color.FromArgb(39, 57, 80);
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void SetearPropiedades()
        {
            nombretxt.Text = jugadorEditar.Nombre;
            apellidotxt.Text = jugadorEditar.Apellido;
            dniNumeric.Value = jugadorEditar.Dni;
            edadNumeric.Value = jugadorEditar.Edad;
            lugarNacimientotxt.Text = jugadorEditar.LugarNacimiento;
            fechaNacimiento.Value = jugadorEditar.FechaNacimiento;
        }
        private void editarJugadorBtn_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nombretxt.Text) ||
                string.IsNullOrWhiteSpace(apellidotxt.Text) ||
                dniNumeric.Value <= 0 ||
                edadNumeric.Value <= 0 ||
                string.IsNullOrWhiteSpace(lugarNacimientotxt.Text) ||
                fechaNacimiento.Value == null)
            {
                MessageBox.Show("Por favor, completa todos los campos correctamente.");
                return;
            }

            jugadorEditar = new CLSJugador(jugadorEditar.Id, nombretxt.Text, apellidotxt.Text, Convert.ToInt32(edadNumeric.Value), Convert.ToInt32(dniNumeric.Value), fechaNacimiento.Value, lugarNacimientotxt.Text, jugadorEditar.EquipoId, jugadorEditar.Rol);
            jugadoresService.editarJugador(jugadorEditar);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void FRMEditarJugador_Load(object sender, EventArgs e)
        {

        }

        private void cerrarAplicacionBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
