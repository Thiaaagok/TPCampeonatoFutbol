using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPCampeonatoFutbol.Modelos;

namespace TPCampeonatoFutbol.Servicios.Interfaces
{
    public interface IPartidosService
    {
        List<CLSEquipo> ObtenerTodos();

        CLSPartidoResultado ObtenerPartidoJugado(Guid partidoId);

        void GuardarPartido(CLSPartido partido);

        void GuardarPartidos(List<CLSPartido> partidos);

        void RegistrarGoles(List<CLSGolesEquipo> goles);

        void RegistrarExpulsiones(List<CLSExpulsion> expulsiones);

        void RegistrarPartido(Guid partidoId, int golesLocal, int golesVisitante, int expulsionesLocal, int expulsionesVisitante);
    }
}
