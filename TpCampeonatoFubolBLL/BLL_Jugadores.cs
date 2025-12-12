using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TpCampeonatoFutbolBE;
using TpCampeonatoFutbolMPP;

namespace TpCampeonatoFubolBLL
{
    public class BLL_Jugadores
    {
        MPP_Jugadores MPP_Jugadores = new MPP_Jugadores();
        public List<JugadorBE> ObtenerTodos()
        {
            return MPP_Jugadores.ObtenerJugadores();
        }

        public JugadorBE ObtenerJugador(Guid id)
        {
            return MPP_Jugadores.ObtenerJugador(id);
        }

    }
}
