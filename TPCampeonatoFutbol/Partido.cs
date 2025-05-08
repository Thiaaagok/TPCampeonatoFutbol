using System;
using System.Collections.Generic;

namespace TPCampeonatoFutbol
{
    internal class Partido
    {
        DateTime Dia { get; set; }
        DateTime Hora { get; set; }
        string Estadio { get; set; }
        Persona Arbitro { get; set; }
        Int32 goles {  get; set; }

        List<Equipo> Equipos { get; set; }
        List<EstadisticasEquipo> EstadisticasEquipos {  get; set; }
    }
}