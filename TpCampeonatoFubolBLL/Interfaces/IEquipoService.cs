using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPCampeonatoFutbol.Modelos;

namespace TPCampeonatoFutbol.Servicios.Interfaces
{
    public interface IEquipoService
    {
        bool CrearEquipo(
            string nombre,
            string nombreCorto,
            string ciudad,
            string estadio,
            int capacidadEstadio,
            int anioFundacion,
            out string mensaje,
            out CLSEquipo equipoCreado
        );

        void editarEquipo(CLSEquipo equipoEditado);

        List<CLSEquipo> ObtenerTodos();

        CLSEquipo ObtenerEquipoPorId(Guid id);

        string ObtenerNombrePorId(Guid id);

        void registrarEquiposEstadisticasVacio(List<CLSEquipo> equipos);

        void registrarPartidoEquipo(Guid equipoId, string resultado, int goles, int expulsiones);

        List<ClSEstadisticasCampeonato> ObtenerEstadisticasCampeonato();

    }
}
