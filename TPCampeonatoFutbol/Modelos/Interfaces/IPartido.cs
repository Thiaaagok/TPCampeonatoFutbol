using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPCampeonatoFutbol.Modelos.Interfaces
{
    public interface IPartido
    {
        DateTime Dia { get; set; }
        TimeSpan Hora { get; set; }
        string Estadio { get; set; }
        CLSPersona Arbitro { get; set; }
        Guid Local { get; set; }
        Guid Visitante { get; set; }
    }
}
