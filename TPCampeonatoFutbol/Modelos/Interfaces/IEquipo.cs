using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPCampeonatoFutbol.Modelos.Interfaces
{
    public interface IEquipo
    {
        Guid Id { get; set; }
        string Nombre { get; set; }
        string NombreCorto { get; set; }
        string Ciudad { get; set; }
        string Estadio { get; set; }
        int CapacidadEstadio { get; set; }
        int AnioFundacion { get; set; }
        List<CLSJugador> Jugadores { get; set; }
    }
}
