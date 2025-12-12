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

namespace TPCampeonatoFutbol
{
    public partial class FRMCrearEquipo : Form
    {

        public FRMCrearEquipo()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.BackColor = Color.FromArgb(39, 57, 80);
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        //public CLSEquipo EquipoCreado { get; private set; }

        //private readonly EquiposService equiposService = new EquiposService();

        //private void crearEquipobtn_Click(object sender, EventArgs e)
        //{
        //    string mensaje;
        //    CLSEquipo equipo;

        //    bool creado = equiposService.CrearEquipo(
        //        nombretxt.Text,
        //        nombrecortotxt.Text,
        //        ciudadtxt.Text,
        //        estadiotxt.Text,
        //        Convert.ToInt32(capacidadEstadioNumber.Value),
        //        Convert.ToInt32(anioFundacionNumber.Value),
        //        out mensaje,
        //        out equipo
        //    );

        //    if (!creado)
        //    {
        //        MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        return;
        //    }

        //    EquipoCreado = equipo;
        //    this.DialogResult = DialogResult.OK;
        //    this.Close();
        //}

        private void cerrarAplicacionBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
