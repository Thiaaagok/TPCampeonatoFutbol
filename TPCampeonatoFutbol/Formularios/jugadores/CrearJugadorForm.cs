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

namespace TPCampeonatoFutbol.Formularios.jugadores
{
    public partial class CrearJugadorForm : Form
    {
        Equipo equipo = new Equipo();
        Rol rolSeleccionado;
        public CrearJugadorForm(Equipo equipo,string rolDescripcion)
        {
            InitializeComponent();
            this.equipo = equipo;
            rolSeleccionado = Rol.ObtenerRoles()
            .FirstOrDefault(r => r.Descripcion.Equals(rolDescripcion, StringComparison.OrdinalIgnoreCase));

        }

        public Jugador NuevoJugador { get; private set; }

        private void crearJugadorBtn_Click(object sender, EventArgs e)
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

            Int32 dni = Convert.ToInt32(dniNumeric.Value);
            Int32 edad = Convert.ToInt32(edadNumeric.Value);
            NuevoJugador = new Jugador(
               nombretxt.Text,
               apellidotxt.Text,
               edad,
               dni,
               fechaNacimiento.Value,
               lugarNacimientotxt.Text,
               equipo,
               rolSeleccionado);
            string nuevaLinea = $"{NuevoJugador.Nombre},{NuevoJugador.Apellido},{NuevoJugador.Edad},{NuevoJugador.Dni},{NuevoJugador.FechaNacimiento},{NuevoJugador.LugarNacimiento},{NuevoJugador.Equipo.Nombre},{NuevoJugador.Rol.Codigo}";
            ManejoArchivos manejoArchivos = new ManejoArchivos();
            manejoArchivos.GuardarNuevo("jugadores.txt", nuevaLinea);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
