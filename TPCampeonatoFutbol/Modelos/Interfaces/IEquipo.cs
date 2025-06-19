using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPCampeonatoFutbol.Modelos.Interfaces
{
    public interface IEquipo
    {
        string Id { get; set; }
        string Nombre { get; set; }
        string Ciudad { get; set; }
        List<CLSJugador> Jugadores { get; set; }
    }
}
