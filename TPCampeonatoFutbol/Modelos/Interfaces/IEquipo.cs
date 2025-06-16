using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPCampeonatoFutbol.Modelos.Interfaces
{
    public interface IEquipo
    {
        string Nombre { get; }
        string Ciudad { get; }
        List<CLSJugador> Jugadores { get; }
    }
}
