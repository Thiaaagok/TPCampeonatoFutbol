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

namespace TPCampeonatoFutbol.Formularios.Arbitros
{
    public partial class FRMCrearArbitro : Form
    {
        ArbitrosBLL arbitrosBLL = new ArbitrosBLL();
        public FRMCrearArbitro()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.BackColor = Color.FromArgb(39, 57, 80);
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        public ArbitroBE NuevoArbitro { get; private set; }

        private void cerrarAplicacionBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void crearArbitroBtn_Click(object sender, EventArgs e)
        {
            string mensaje;
            ArbitroBE arbitro;

            bool creado = arbitrosBLL.CrearArbitro(
                nombretxt.Text,
                apellidotxt.Text,
                Convert.ToInt32(edadNumeric.Value),
                Convert.ToInt32(dniNumeric.Value),
                fechaNacimiento.Value,
                lugarNacimientotxt.Text,
                out mensaje,
                out arbitro
            );

            if (!creado)
            {
                MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            NuevoArbitro = arbitro;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
