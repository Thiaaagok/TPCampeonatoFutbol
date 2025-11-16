using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TpCampeonatoFutbolBE;

namespace TPCampeonatoFutbol.Servicios.Interfaces
{
    public interface IJugadoresService
    {
        List<JugadorBE> ObtenerPorEquipoId(Guid equipoId);

        bool CrearJugador(
            string nombre,
            string apellido,
            int edad,
            int dni,
            DateTime fechaNacimiento,
            string lugarNacimiento,
            Guid equipoId,
            RolBE rol,
            out string mensaje,
            out JugadorBE nuevoJugador);

        void editarJugador(JugadorBE jugadorEditado);

        List<JugadorBE> ObtenerTodos();
    }
}
