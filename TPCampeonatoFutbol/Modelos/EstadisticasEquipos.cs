using System;
using System.Collections.Generic;

namespace TPCampeonatoFutbol
{
    internal class EstadisticasEquipo
    {
        Equipo Equipo { get; set; }
        List<GolesEquipo> GolesEquipo { get; set; }
        List<Expulsion> Expulsiones { get; set; }
    }
}