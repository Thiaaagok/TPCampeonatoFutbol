using System.Collections.Generic;

namespace TPCampeonatoFutbol
{
    internal class Campeonato
    {
        List<Partido> Partidos {  get; set; }
        List<Equipo> Equipos { get; set; }
        List<PlantelEquipo> Planteles { get; set; }
        List<HistorialEquipo> Historiales { get; set; }
        List<PuntajeEquipo> Puntajes { get; set; }
    }

}