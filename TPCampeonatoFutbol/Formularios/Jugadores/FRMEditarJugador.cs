using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPCampeonatoFutbol.Formularios.jugadores
{
    public partial class FRMEditarJugador : Form
    {
        private CLSJugador jugadorEditar;

        public FRMEditarJugador(CLSJugador jugador)
        {
            InitializeComponent();
            jugadorEditar = jugador;
            SetearPropiedades();
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

            jugadorEditar.Nombre = nombretxt.Text;
            jugadorEditar.Apellido = apellidotxt.Text;
            jugadorEditar.Dni = Convert.ToInt32(dniNumeric.Value);
            jugadorEditar.Edad = Convert.ToInt32(edadNumeric.Value);
            jugadorEditar.LugarNacimiento = lugarNacimientotxt.Text;
            jugadorEditar.FechaNacimiento = fechaNacimiento.Value;

            jugadorEditar.editarJugador(jugadorEditar);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
