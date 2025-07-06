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
        public List<CLSEquipo> ObtenerTodos()
        {
            try
            {
                List<string> lineas = manejoArchivos.ObtenerTodos("partidos.txt");
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
            manejoArchivos.GuardarNuevo("partidos.txt", linea);
        }

        public void GuardarPartidos(List<CLSPartido> partidos)
        {
            foreach (var partido in partidos)
            {
                GuardarPartido(partido);
            }
        }
    }
}
