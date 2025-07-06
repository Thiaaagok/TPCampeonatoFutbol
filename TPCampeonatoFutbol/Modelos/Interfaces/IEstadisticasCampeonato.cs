using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPCampeonatoFutbol.Modelos.Interfaces
{
    public interface IEstadisticasCampeonato
    {
        Guid Id { get; set; }
        CLSEquipo Equipo { get; set; }
        List<CLSPartido> PartidosJugados { get; set; }
        int Puntos { get; set; }
        int Goles { get; set; }
        int CantPartidosJugados { get; set; }
        int PartidosGanados { get; set; }
        int PartidosEmpatados { get; set; }
        int PartidosPerdidos { get; set; }
    }
}
