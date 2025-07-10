using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPCampeonatoFutbol.Funciones;
using TPCampeonatoFutbol.Modelos;

namespace TPCampeonatoFutbol.Servicios
{
    public class EquiposService
    {
        private readonly ManejoArchivos manejoArchivos = new ManejoArchivos();
        private readonly string ruta = "equipos.txt";
        private readonly string rutaEquipoEstadisticas = "equiposEstadisticas.txt";
        /* EquipoId;Puntos;PartidosJugados;PartidosGanados;PartidosEmpatados;PartidosPerdidos;Goles;Expulsiones; */

        public bool CrearEquipo(
            string nombre,
            string nombreCorto,
            string ciudad,
            string estadio,
            int capacidadEstadio,
            int anioFundacion,
            out string mensaje,
            out CLSEquipo equipoCreado)
        {
            mensaje = "";
            equipoCreado = null;

            if (string.IsNullOrWhiteSpace(nombre) ||
                string.IsNullOrWhiteSpace(nombreCorto) ||
                capacidadEstadio <= 0 ||
                string.IsNullOrWhiteSpace(estadio) ||
                anioFundacion <= 0)
            {
                mensaje = "Todos los campos deben estar completos y válidos.";
                return false;
            }

            equipoCreado = new CLSEquipo(
                Guid.NewGuid(),
                nombre,
                nombreCorto,
                ciudad,
                estadio,
                capacidadEstadio,
                anioFundacion
            );

            string nuevaLinea = $"{equipoCreado.Id};{equipoCreado.Nombre};{equipoCreado.NombreCorto};{equipoCreado.Ciudad};{equipoCreado.Estadio};{equipoCreado.CapacidadEstadio};{equipoCreado.AnioFundacion}";

            manejoArchivos.GuardarNuevo(ruta, nuevaLinea);

            return true;
        }

        public void editarEquipo(CLSEquipo equipoEditado)
        {

            manejoArchivos.EditarRegistro<CLSEquipo>(
                ruta,
                e => e.Id == equipoEditado.Id,
                equipoEditado,
                equipo => $"{equipoEditado.Id};{equipo.Nombre};{equipo.NombreCorto};{equipo.Ciudad};{equipo.Estadio};{equipo.CapacidadEstadio};{equipo.AnioFundacion}",
                linea =>
                {
                    var partes = linea.Split(';');
                    return new CLSEquipo(
                        Guid.Parse(partes[0]),
                        partes[1],
                        partes[2],
                        partes[3],
                        partes[4],
                        int.Parse(partes[5]),
                        int.Parse(partes[6])
                    );
                });
        }

        public List<CLSEquipo> ObtenerTodos()
        {
            try
            {
                List<string> lineas = manejoArchivos.ObtenerTodos("equipos.txt");
                List<CLSEquipo> equipos = new List<CLSEquipo>();

                foreach (var linea in lineas)
                {
                    var partes = linea.Split(';');

                    CLSEquipo equipo = new CLSEquipo(
                        Guid.Parse(partes[0]),
                        partes[1],
                        partes[2],
                        partes[3],
                        partes[4],
                        int.Parse(partes[5]),
                        int.Parse(partes[6])
                    );

                    equipos.Add(equipo);
                }

                return equipos;
            }
            catch (Exception)
            {
                throw; 
            }
        }

        public CLSEquipo ObtenerEquipoPorId(Guid id)
        {
            return manejoArchivos.ObtenerRegistroPorId<CLSEquipo>(
                ruta,
                e => e.Id == id,
                linea =>
                {
                    var partes = linea.Split(';');
                    return new CLSEquipo(
                        Guid.Parse(partes[0]),
                        partes[1],
                        partes[2],
                        partes[3],
                        partes[4],
                        int.Parse(partes[5]),
                        int.Parse(partes[6])
                    );
                });
        }

        public string ObtenerNombrePorId(Guid id)
        {
            var equipos = ObtenerTodos(); 
            var equipo = equipos.FirstOrDefault(e => e.Id == id);
            return equipo?.Nombre ?? "Desconocido";
        }

        public void registrarEquiposEstadisticasVacio(List<CLSEquipo> equipos)
        {
            List<string> lineasGuardar = new List<string>();
            foreach (CLSEquipo equipo in equipos)
            {
                /* Id;EquipoId;Puntos;PartidosJugados;PartidosGanados;PartidosEmpatados;PartidosPerdidos;Goles;Expulsiones; */
                ClSEstadisticasCampeonato clsEstadisticasCampeonato = new ClSEstadisticasCampeonato(equipo.Id,0,0,0,0,0,0,0);
                string linea = $"{clsEstadisticasCampeonato.Id};{clsEstadisticasCampeonato.Equipo};{clsEstadisticasCampeonato.Puntos};{clsEstadisticasCampeonato.CantPartidosJugados};{clsEstadisticasCampeonato.PartidosGanados};{clsEstadisticasCampeonato.PartidosEmpatados};{clsEstadisticasCampeonato.PartidosPerdidos};{clsEstadisticasCampeonato.Goles};{clsEstadisticasCampeonato.Expulsiones}";
                lineasGuardar.Add(linea);
            }
            manejoArchivos.GuardarTodos(rutaEquipoEstadisticas, lineasGuardar);
        }

        public void registrarPartidoEquipo(Guid equipoId, string resultado, int goles, int expulsiones)
        {
            ClSEstadisticasCampeonato clsEstadisticasCampeonato = manejoArchivos.ObtenerRegistroPorId<ClSEstadisticasCampeonato>(
            ruta,
            e => e.Equipo == equipoId,
            linea =>
            {
                var partes = linea.Split(';');
                return new ClSEstadisticasCampeonato(
                    Guid.Parse(partes[0]),
                    Guid.Parse(partes[1]),
                    int.Parse(partes[2]),
                    int.Parse(partes[3]),
                    int.Parse(partes[4]),
                    int.Parse(partes[5]),
                    int.Parse(partes[6]),
                    int.Parse(partes[7]),
                    int.Parse(partes[8])
                );
            });

            clsEstadisticasCampeonato.CantPartidosJugados++;

            switch (resultado.ToUpper())
            {
                case "GANADO":
                    clsEstadisticasCampeonato.PartidosGanados++;
                    clsEstadisticasCampeonato.Puntos += 3;
                    break;
                case "EMPATADO":
                    clsEstadisticasCampeonato.PartidosEmpatados++;
                    clsEstadisticasCampeonato.Puntos += 1;
                    break;
                case "PERDIDO":
                    clsEstadisticasCampeonato.PartidosPerdidos++;
                    break;
                default:
                    throw new ArgumentException("Resultado inválido: debe ser GANADO, EMPATADO o PERDIDO");
            }
            clsEstadisticasCampeonato.Goles += goles;
            clsEstadisticasCampeonato.Expulsiones += expulsiones;
            manejoArchivos.EditarRegistro<ClSEstadisticasCampeonato>(
               ruta,
               e => e.Id == clsEstadisticasCampeonato.Id,
               clsEstadisticasCampeonato,
               e => $"{e.Id};{e.Equipo};{e.Puntos};{e.CantPartidosJugados};{e.PartidosGanados};{e.PartidosEmpatados};{e.PartidosPerdidos};{e.Goles};{e.Expulsiones}",
               linea =>
               {
                   var partes = linea.Split(';');
                   return new ClSEstadisticasCampeonato(
                       Guid.Parse(partes[0]),
                       Guid.Parse(partes[1]),
                       int.Parse(partes[2]),
                       int.Parse(partes[3]),
                       int.Parse(partes[4]),
                       int.Parse(partes[5]),
                       int.Parse(partes[6]),
                       int.Parse(partes[7]),
                       int.Parse(partes[8])
                   );
               });
        }
    }
}
