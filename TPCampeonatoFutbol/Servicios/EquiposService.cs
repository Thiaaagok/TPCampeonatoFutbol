using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPCampeonatoFutbol.Funciones;

namespace TPCampeonatoFutbol.Servicios
{
    public class EquiposService
    {
        private readonly ManejoArchivos manejoArchivos = new ManejoArchivos();
        private readonly string ruta = "equipos.txt";

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
            ManejoArchivos archivos = new ManejoArchivos();

            archivos.EditarRegistro<CLSEquipo>(
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
    }
}
