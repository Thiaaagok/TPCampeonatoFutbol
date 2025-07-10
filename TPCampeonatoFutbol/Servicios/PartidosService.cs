using NAudio.CoreAudioApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPCampeonatoFutbol.Funciones;

namespace TPCampeonatoFutbol.Servicios
{
    public class PartidosService
    {
        private readonly ManejoArchivos manejoArchivos = new ManejoArchivos();
        private string rutaPartidos = "partidos.txt";
        private string rutaPartidosGoles = "partidosGoles.txt";
        private string rutaPartidosExpulsiones = "partidosExpulsiones.txt";
        private string rutaPartidosEstadisticas = "partidosEstadisticas.txt";
        public List<CLSEquipo> ObtenerTodos()
        {
            try
            {
                List<string> lineas = manejoArchivos.ObtenerTodos(rutaPartidos);
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

        public void GuardarPartido(CLSPartido partido)
        {
            string linea = $"{partido.Id};{partido.Local};{partido.Visitante};{partido.IdFecha};{partido.Estadio};{partido.Dia};{partido.Hora}";
            manejoArchivos.GuardarNuevo(rutaPartidos, linea);
        }

        public void GuardarPartidos(List<CLSPartido> partidos)
        {
            foreach (var partido in partidos)
            {
                GuardarPartido(partido);
            }
        }

        public void RegistrarGoles(List<CLSGolesEquipo> goles)
        {
            if(goles.Count > 0 )
            {
                List<string> lineasGuardar = new List<string>();
                foreach(CLSGolesEquipo gol in goles)
                {
                    string linea = $"{gol.Id};{gol.PartidoId};{gol.EquipoId};{gol.AutorId};{gol.Autor};{gol.Minutos}";
                    lineasGuardar.Add(linea);
                }
                manejoArchivos.GuardarTodos(rutaPartidosGoles, lineasGuardar);
            }
        }

        public void RegistrarExpulsiones(List<CLSExpulsion> expulsiones)
        {
            if(expulsiones.Count > 0)
            {
                List<string> lineasGuardar = new List<string>();
                foreach (CLSExpulsion expulsion in expulsiones)
                {
                    string linea = $"{expulsion.Id};{expulsion.PartidoId};{expulsion.EquipoId};{expulsion.AutorId};{expulsion.Autor};{expulsion.Minutos}";
                    lineasGuardar.Add(linea);
                }
                manejoArchivos.GuardarTodos(rutaPartidosExpulsiones, lineasGuardar);
            }
        }

        public void RegistrarPartido(CLSPartido partido, int GolesLocal, int GolesVisitante, int expulsionesLocal, int expulsionesVisitante)
        {
            string linea = $"{partido.Id};{GolesLocal};{GolesVisitante};{expulsionesLocal};{expulsionesVisitante}";
            manejoArchivos.GuardarNuevo(rutaPartidosEstadisticas, linea);
        }
    }
}
