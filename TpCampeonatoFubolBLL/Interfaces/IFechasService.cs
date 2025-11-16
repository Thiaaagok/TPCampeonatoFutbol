using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPCampeonatoFutbol.Modelos;

namespace TPCampeonatoFutbol.Servicios.Interfaces
{
    public interface IFechasService
    {
        void GuardarFecha(CLSFecha fecha, int numeroFecha);

        List<CLSFecha> CargarFechasDesdeArchivos();
    }
}
