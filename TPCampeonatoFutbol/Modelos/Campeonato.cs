using System;
using System.Collections.Generic;

namespace TPCampeonatoFutbol
{
    public class Campeonato
    {
        List<Partido> Partidos {  get; set; }
        List<Equipo> Equipos { get; set; }
        List<PlantelEquipo> Planteles { get; set; }
        List<HistorialEquipo> Historiales { get; set; }
        List<PuntajeEquipo> Puntajes { get; set; }

        private static readonly Lazy<Campeonato> instancia = new Lazy<Campeonato>(() => new Campeonato());

        private Campeonato()
        {
            Partidos = new List<Partido>();
            Equipos = new List<Equipo>();
            Planteles = new List<PlantelEquipo>();
            Historiales = new List<HistorialEquipo>();
            Puntajes = new List<PuntajeEquipo>();
        }

        public static Campeonato Instancia => instancia.Value;
    }

}