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
        CLSJugador jugadorEditar { get; set; }
        public FRMEditarJugador(CLSJugador jugadorEditar)
        {
            InitializeComponent();
            this.jugadorEditar = jugadorEditar;
        }
        private void SetearPropiedades()
        {

        }
    }
}
