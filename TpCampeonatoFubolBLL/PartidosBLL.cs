using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TpCampeonatoFutbolBE;

namespace TpCampeonatoFubolBLL
{
    public class PartidosBLL
    {
        public List<EquipoBE> ObtenerTodos()
        {
            return null;
        }

        public PartidoBE ObtenerPartidoJugado(Guid partidoId)
        {
            return null;
        }
        public void GuardarPartido(PartidoBE partido)
        {

        }

        public void GuardarPartidos(List<PartidoBE> partidos)
        {
            foreach (var partido in partidos)
            {
                GuardarPartido(partido);
            }
        }

        public void RegistrarGoles(List<GolBE> goles)
        {

        }

        public void RegistrarExpulsiones(List<ExpulsionBE> expulsiones)
        {

        }

        public void RegistrarPartido(Guid partidoId, int GolesLocal, int GolesVisitante, int expulsionesLocal, int expulsionesVisitante)
        {

        }

    }
}
