using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPCampeonatoFutbol.Modelos.Interfaces;

namespace TPCampeonatoFutbol.Modelos.Funciones
{
    public class GeneradorDeFixture
    {
        public List<CLSFecha> Generar(List<CLSEquipo> equipos)
        {
            {
                List<CLSFecha> fechas = new List<CLSFecha>();
                Random rand = new Random();

                if (equipos.Count % 2 != 0)
                {
                    throw new ArgumentException("la cantidad de equipos debe ser par");
                }

                int cantidadFechas = (equipos.Count * 2) - 2;
                List<CLSEquipo> EquipoOriginal = new List<CLSEquipo>(equipos);

                for (int i = 0; i < cantidadFechas; i++)
                {
                    CLSFecha fecha = new CLSFecha();

                    List<CLSEquipo> EquiposDisponibles = new List<CLSEquipo>(EquipoOriginal);
                    int index1 = rand.Next(equipos.Count);
                    CLSEquipo equipo1 = EquiposDisponibles[index1];
                    EquiposDisponibles.RemoveAt(index1);

                    int index2 = rand.Next(equipos.Count);
                    CLSEquipo equipo2 = EquiposDisponibles[index2];
                    EquiposDisponibles.RemoveAt(index2);

                    if (i % 2 == 0)
                    {
                        CLSPartido partido = new CLSPartido();
                        partido.Local = equipo1;
                        partido.Visitante = equipo2;
                        fecha.Partidos.Add(partido);
                    }
                    else
                    {
                        CLSPartido partido = new CLSPartido();
                        partido.Local = equipo2;
                        partido.Visitante = equipo1;
                        fecha.Partidos.Add(partido);
                    }

                    fechas.Add(fecha);

                }
                return fechas;
            }
        }
    }
}
