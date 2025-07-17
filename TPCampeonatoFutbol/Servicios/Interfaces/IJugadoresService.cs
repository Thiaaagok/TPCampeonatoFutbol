using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPCampeonatoFutbol.Servicios.Interfaces
{
    public interface IJugadoresService
    {
        List<CLSJugador> ObtenerPorEquipoId(Guid equipoId);

        bool CrearJugador(
            string nombre,
            string apellido,
            int edad,
            int dni,
            DateTime fechaNacimiento,
            string lugarNacimiento,
            Guid equipoId,
            CLSRol rol,
            out string mensaje,
            out CLSJugador nuevoJugador);

        void editarJugador(CLSJugador jugadorEditado);

        List<CLSJugador> ObtenerTodos();
    }
}
