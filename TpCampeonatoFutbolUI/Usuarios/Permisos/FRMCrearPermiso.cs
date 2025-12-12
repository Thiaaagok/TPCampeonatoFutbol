using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TpCampeonatoFubolBLL;
using TpCampeonatoFutbolBE;
using TpCampeonatoFutbolUI.Navegacion;

namespace TpCampeonatoFutbolUI.Usuarios.Permisos
{
    public partial class FRMCrearPermiso : Form
    {
        BLL_Permisos BLL_Permisos = new BLL_Permisos();
        public FRMCrearPermiso()
        {
            InitializeComponent();
        }

        public void AgregarDiseños()
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.BackColor = Color.FromArgb(39, 57, 80);
            this.StartPosition = FormStartPosition.CenterScreen;
            codigoLabel.ForeColor = Color.White;
            descripcionLabel.ForeColor = Color.White;
        }

        private void FRMCrearPermiso_Load(object sender, EventArgs e)
        {
            AgregarDiseños();
        }

        private void CrearPermiso()
        {
            PermisoBE permiso = new PermisoBE(CodigoText.Text,descripcionText.Text);
            BLL_Permisos.CrearPermiso(permiso);
        }

        private void CancelarBTN_Click(object sender, EventArgs e)
        {
            NavegacionService.Instance.Navegar(RutaFormulario.Permisos, null);
        }

        private void CrearPermisoBtn_Click(object sender, EventArgs e)
        {
            CrearPermiso();
        }
    }
}
