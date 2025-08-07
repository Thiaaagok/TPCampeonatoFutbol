using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPCampeonatoFutbol.Modelos.Interfaces;
using TPCampeonatoFutbol.Servicios;

namespace TPCampeonatoFutbol.Modelos.Funciones
{
    public class GeneradorDeFixture
    {
        public ArbitroService ArbitrosService = new ArbitroService();
        public List<CLSFecha> Generar(List<CLSEquipo> equipos, DateTime fechaInicio)
        {
            List<CLSArbitro> arbitros = ArbitrosService.ObtenerTodos();

            if (arbitros == null || !arbitros.Any())
                throw new InvalidOperationException("No hay árbitros disponibles.");

            if (equipos.Count % 2 != 0)
                throw new ArgumentException("La cantidad de equipos debe ser par");

            int n = equipos.Count;
            int cantidadFechas = (n - 1) * 2;
            List<CLSFecha> fechas = new List<CLSFecha>();

            Random rng = new Random();
            List<CLSEquipo> equiposFixture = equipos.OrderBy(x => rng.Next()).ToList();

            List<TimeSpan> horariosDisponibles = new List<TimeSpan>()
    {
        new TimeSpan(14, 0, 0),
        new TimeSpan(16, 0, 0),
        new TimeSpan(18, 0, 0),
        new TimeSpan(20, 0, 0)
    };

            int numeroFecha = 0;
            int arbitroIndex = 0;

            for (int vuelta = 0; vuelta < 2; vuelta++)
            {
                for (int ronda = 0; ronda < n - 1; ronda++)
                {
                    CLSFecha fecha = new CLSFecha()
                    {
                        Id = Guid.NewGuid(),
                        Dia = fechaInicio.AddDays(numeroFecha)
                    };

                    fecha.Partidos = new List<CLSPartido>();

                    for (int i = 0; i < n / 2; i++)
                    {
                        CLSEquipo local, visitante;

                        if (vuelta == 0)
                        {
                            local = equiposFixture[i];
                            visitante = equiposFixture[n - 1 - i];
                        }
                        else
                        {
                            local = equiposFixture[n - 1 - i];
                            visitante = equiposFixture[i];
                        }

                        if (rng.Next(2) == 0)
                        {
                            var aux = local;
                            local = visitante;
                            visitante = aux;
                        }

                        TimeSpan horaPartido = horariosDisponibles[rng.Next(horariosDisponibles.Count)];

                        // Asignar árbitro rotando
                        CLSArbitro arbitroAsignado = arbitros[arbitroIndex];
                        arbitroIndex = (arbitroIndex + 1) % arbitros.Count;

                        CLSPartido partido = new CLSPartido()
                        {
                            Local = local.Id,
                            Visitante = visitante.Id,
                            IdFecha = fecha.Id,
                            Dia = fecha.Dia,
                            Hora = horaPartido,
                            Estadio = local.Estadio,
                            Arbitro = arbitroAsignado.Id
                        };

                        fecha.Partidos.Add(partido);
                    }

                    fechas.Add(fecha);

                    // Rotar equipos
                    var temp = equiposFixture[n - 1];
                    for (int j = n - 1; j > 1; j--)
                        equiposFixture[j] = equiposFixture[j - 1];
                    equiposFixture[1] = temp;

                    numeroFecha++;
                }
            }

            return fechas;
        }

    }
}
