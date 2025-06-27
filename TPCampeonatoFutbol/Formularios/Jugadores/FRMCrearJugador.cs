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
    public partial class FRMCrearJugador : Form
    {
        CLSEquipo equipo = new CLSEquipo();
        CLSRol rolSeleccionado = new CLSRol();
        public FRMCrearJugador(CLSEquipo equipo,string rolDescripcion)
        {
            InitializeComponent();
            this.equipo = equipo;
            rolSeleccionado = CLSRol.ObtenerRoles()
            .FirstOrDefault(r => r.Codigo == rolDescripcion);

        }

        public CLSJugador NuevoJugador { get; private set; }

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
            NuevoJugador = new CLSJugador(
               null,
               nombretxt.Text,
               apellidotxt.Text,
               edad,
               dni,
               fechaNacimiento.Value,
               lugarNacimientotxt.Text,
               equipo.Id,
               rolSeleccionado);
            string nuevaLinea = $"{NuevoJugador.Id},{NuevoJugador.Nombre},{NuevoJugador.Apellido},{NuevoJugador.Edad},{NuevoJugador.Dni},{NuevoJugador.FechaNacimiento},{NuevoJugador.LugarNacimiento},{NuevoJugador.EquipoId},{NuevoJugador.Rol.Codigo},{NuevoJugador.Rol.Descripcion}";
            ManejoArchivos manejoArchivos = new ManejoArchivos();
            manejoArchivos.GuardarNuevo("jugadores.txt", nuevaLinea);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
