using System;
using System.Collections.Generic;

namespace TPCampeonatoFutbol
{
    public class Equipo
    {
        public string Nombre {  get; set; }

        public string NombreCorto { get; set; }

        public string Ciudad { get; set; }

        public string Estadio { get; set; }

        public int CapacidadEstadio { get; set; }

        public int AnioFundacion { get; set; }

        public List<Jugador> Jugadores { get; set; }

        public Equipo()
        {
            Jugadores = new List<Jugador>();
        }

        public Equipo(string nombre, string nombreCorto, string ciudad, string estadio, int capacidadEstadio, int anioFundacion)
        {
            Nombre = nombre;
            NombreCorto = nombreCorto;
            Ciudad = ciudad;
            Estadio = estadio;
            CapacidadEstadio = capacidadEstadio;
            AnioFundacion = anioFundacion;
        }
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