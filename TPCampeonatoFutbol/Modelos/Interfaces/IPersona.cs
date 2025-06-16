using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPCampeonatoFutbol.Modelos.Interfaces
{
    public interface IPersona
    {
        int Edad { get; set; }
        string Nombre { get; set; }
        string Apellido { get; set; }
    }
}
