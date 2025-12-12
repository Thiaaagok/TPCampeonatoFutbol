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

namespace TpCampeonatoFutbolUI.Usuarios.Roles
{
    public partial class FRMEditarRol : Form
    {
        BLL_Permisos BLL_Permisos = new BLL_Permisos();
        public FRMEditarRol()
        {
            InitializeComponent();
            var permisos = BLL_Permisos.ObtenerTodos();

            permisosListBox.DataSource = permisos;
            permisosListBox.DisplayMember = "Descripcion";
            permisosListBox.ValueMember = "Id";
        }
    }
}
