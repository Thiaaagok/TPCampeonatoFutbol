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
    public partial class FRMEditarPermiso : Form
    {
        BLL_Permisos BLL_Permisos = new BLL_Permisos();
        PermisoBE Permiso = new PermisoBE();
        public FRMEditarPermiso(Guid id)
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

        public void ObtenerPermiso(Guid id) 
        {
            Permiso = BLL_Permisos.ObtenerPermiso(id);
            descripcionText.Text = Permiso.Descripcion;
            CodigoText.Text = Permiso.Codigo;
        }

        public void EditarPermiso()
        {
            Permiso.Codigo = CodigoText.Text;
            Permiso.Descripcion = descripcionText.Text;
            BLL_Permisos.EditarPermiso(Permiso);
            NavegacionService.Instance.Navegar(RutaFormulario.Permisos, null);
        }

        private void FRMEditarPermiso_Load(object sender, EventArgs e)
        {
            AgregarDiseños();
        }

        private void CancelarBTN_Click(object sender, EventArgs e)
        {
            NavegacionService.Instance.Navegar(RutaFormulario.Permisos, null);
        }

        private void EditarPermisoBtn_Click(object sender, EventArgs e)
        {
            EditarPermiso();
        }
    }
}
