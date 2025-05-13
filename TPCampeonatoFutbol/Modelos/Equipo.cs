using System;
using System.Collections.Generic;

namespace TPCampeonatoFutbol
{
    internal class Equipo
    {
        string nombre {  get; set; }
    }

    internal class PlantelEquipo
    {
        Equipo Equipo { get; set; }
        List<Jugador> Jugadores { get; set; }
    }

    internal class HistorialEquipo
    {
        Equipo Equipo { get; set; }
        List<Partido> PartidosJugados { get; set; }
    }

    internal class PuntajeEquipo
    {
        Equipo Equipo { get; set; }
        int PuntosCampeonato { get; set; }
    }
}