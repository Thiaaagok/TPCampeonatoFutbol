using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TpCampeonatoFutbolUI
{
    public class ManejoFormularios
    {
        private Form formularioActual = null;

        public void AbrirFormulario(Panel panelContenido,Form frm)
        {
            if (formularioActual != null)
                formularioActual.Close();

            formularioActual = frm;
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;

            panelContenido.Controls.Clear();
            panelContenido.Controls.Add(frm);

            frm.Show();
        }
    }
}
