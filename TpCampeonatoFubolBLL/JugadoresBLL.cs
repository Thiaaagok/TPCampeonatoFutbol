using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPCampeonatoFutbol;
using TPCampeonatoFutbol.Modelos.Interfaces;
using TpCampeonatoFutbolBE;

namespace TpCampeonatoFubolBLL
{
    public class JugadoresBLL
    {
        public List<JugadorBE> ObtenerPorEquipoId(Guid equipoId)
        {
            List<JugadorBE> jugadores = new List<JugadorBE>();

            try
            {
                return jugadores;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool CrearJugador(
            string nombre,
            string apellido,
            int edad,
            int dni,
            DateTime fechaNacimiento,
            string lugarNacimiento,
            Guid equipoId,
            RolBE rol,
            out string mensaje,
            out JugadorBE nuevoJugador)
        {
            mensaje = "";
            nuevoJugador = null;

            if (string.IsNullOrWhiteSpace(nombre) ||
                string.IsNullOrWhiteSpace(apellido) ||
                edad <= 0 ||
                dni <= 0 ||
                string.IsNullOrWhiteSpace(lugarNacimiento) ||
                rol == null)
            {
                mensaje = "Por favor, completa todos los campos correctamente.";
                return false;
            }

            return true;
        }

        public void editarJugador(JugadorBE jugadorEditado)
        {
        }

        public List<JugadorBE> ObtenerTodos()
        {
            try
            {
                List<JugadorBE> jugadores = new List<JugadorBE>();
                return jugadores;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<JugadorBE> BuscarPorNombre(string nombreParcial)
        {
            List<JugadorBE> jugadores = new List<JugadorBE>();
            return jugadores;
        }

        public bool ExisteJugadorPorDNI(int dni)
        {
            return true;
        }
    }
}
