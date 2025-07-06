using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPCampeonatoFutbol.Funciones;

namespace TPCampeonatoFutbol.Servicios
{
    public class JugadoresService
    {
        private readonly ManejoArchivos manejoArchivos = new ManejoArchivos();
        private readonly string ruta = "jugadores.txt";

        public List<CLSJugador> ObtenerPorEquipoId(Guid equipoId)
        {
            List<CLSJugador> jugadores = new List<CLSJugador>();

            try
            {
                List<string> lineas = manejoArchivos.ObtenerTodos(ruta);

                foreach (var linea in lineas)
                {
                    string[] partes = linea.Split(';');

                    if (Guid.Parse(partes[7]) == equipoId)
                    {
                        CLSRol rol = new CLSRol(partes[9], partes[8]);

                        CLSJugador jugador = new CLSJugador(
                           Guid.Parse(partes[0]),               // Id
                            partes[1],                          // Nombre
                            partes[2],                          // Apellido
                            Convert.ToInt32(partes[3]),         // Edad
                            Convert.ToInt32(partes[4]),         // Dni
                            Convert.ToDateTime(partes[5]),      // FechaNacimiento
                            partes[6],                          // LugarNacimiento
                            Guid.Parse(partes[7]),              // EquipoId
                            rol                                 // Rol
                        );

                        jugadores.Add(jugador);
                    }
                }

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
            CLSRol rol,
            out string mensaje,
            out CLSJugador nuevoJugador)
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

            nuevoJugador = new CLSJugador(
                Guid.NewGuid(),
                nombre,
                apellido,
                edad,
                dni,
                fechaNacimiento,
                lugarNacimiento,
                equipoId,
                rol
            );

            string nuevaLinea = $"{nuevoJugador.Id};{nuevoJugador.Nombre};{nuevoJugador.Apellido};{nuevoJugador.Edad};{nuevoJugador.Dni};{nuevoJugador.FechaNacimiento};{nuevoJugador.LugarNacimiento};{nuevoJugador.EquipoId};{nuevoJugador.Rol.Codigo};{nuevoJugador.Rol.Descripcion}";

            manejoArchivos.GuardarNuevo(ruta, nuevaLinea);

            return true;
        }

        public void editarJugador(CLSJugador jugadorEditado)
        {
            ManejoArchivos archivos = new ManejoArchivos();

            archivos.EditarRegistro<CLSJugador>(
                ruta,
                j => j.Id == jugadorEditado.Id,
                jugadorEditado,
                jugador => $"{jugador.Id};{jugador.Nombre};{jugador.Apellido};{jugador.Edad};{jugador.Dni};{jugador.FechaNacimiento:dd/MM/yyyy HH:mm:ss};{jugador.LugarNacimiento};{jugador.EquipoId};{jugador.Rol.Codigo};{jugador.Rol.Descripcion}",
                linea =>
                {
                    var partes = linea.Split(',');

                    return new CLSJugador(
                        Guid.Parse(partes[0]),
                        partes[1],
                        partes[2],
                        int.Parse(partes[3]),
                        int.Parse(partes[4]),
                        DateTime.ParseExact(partes[5], "dd/MM/yyyy HH:mm:ss", null),
                        partes[6],
                       Guid.Parse(partes[7]),
                        new CLSRol(partes[8], partes[9])
                    );
                }
            );
        }



    }
}
