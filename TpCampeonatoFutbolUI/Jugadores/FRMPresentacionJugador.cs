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

namespace TpCampeonatoFutbolUI.Jugadores
{
    public partial class FRMPresentacionJugador : Form
    {
        BLL_Jugadores BLL_jugadores = new BLL_Jugadores();
        JugadorBE jugadorPresentar = new JugadorBE();
        public FRMPresentacionJugador(Guid id)
        {
            InitializeComponent();
            ObtenerJugador(id);
        }

        private void ObtenerJugador(Guid id)
        {
            jugadorPresentar = BLL_jugadores.ObtenerJugador(id);
            nombreJugadorLabel.Text = $"{jugadorPresentar.Nombre} {jugadorPresentar.Apellido}";
            EdadLabel.Text = jugadorPresentar.Edad.ToString();
            equipoLabel.Text = jugadorPresentar.EquipoNombre;
            precioJugadorLabel.Text = $"${jugadorPresentar.Precio}";
            GolesLabel.Text = $"{jugadorPresentar.Goles}";
            AmarillasLabel.Text = $"{jugadorPresentar.Goles}";
            RojasLabel.Text = $"{jugadorPresentar.Goles}";
        }
        private void FRMPresentacionJugador_Load(object sender, EventArgs e)
        {

        }
    }
}
