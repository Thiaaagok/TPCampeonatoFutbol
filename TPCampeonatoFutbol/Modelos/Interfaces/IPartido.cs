using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPCampeonatoFutbol.Modelos.Interfaces
{
    public interface IPartido
    {
        CLSEquipo Local { get; set; }
        CLSEquipo Visitante { get; set; }
        DateTime Dia { get; set; }
        DateTime Hora { get; set; }
        string Estadio { get; set; }
    }
}
