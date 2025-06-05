using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPCampeonatoFutbol.Funciones;

namespace TPCampeonatoFutbol
{
    public partial class CrearEquipoForm : Form
    {

        public CrearEquipoForm()
        {
            InitializeComponent(); 
        }

        public Equipo EquipoCreado { get; private set; }

        private void crearEquipobtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nombretxt.Text) ||
                string.IsNullOrWhiteSpace(nombrecortotxt.Text) ||
                anioFundacionNumber.Value <= 0 ||
                string.IsNullOrWhiteSpace(estadiotxt.Text) ||
                capacidadEstadioNumber.Value <= 0)
            {
                MessageBox.Show("Por favor, completa todos los campos correctamente.");
                return;
            }

            Int32 anio = Convert.ToInt32(anioFundacionNumber.Value);
            Int32 capacidadEstadio = Convert.ToInt32(capacidadEstadioNumber.Value);
            EquipoCreado = new Equipo(
                nombretxt.Text,
                nombrecortotxt.Text,
                ciudadtxt.Text,
                estadiotxt.Text,
                capacidadEstadio,
                anio);
            string nuevaLinea = $"{EquipoCreado.Nombre},{EquipoCreado.NombreCorto},{EquipoCreado.Ciudad},{EquipoCreado.Estadio},{EquipoCreado.CapacidadEstadio},{EquipoCreado.AnioFundacion}";
            ManejoArchivos manejoArchivos = new ManejoArchivos();
            manejoArchivos.GuardarNuevo("equipos.txt", nuevaLinea);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
