﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPCampeonatoFutbol.Modelos.Interfaces;

namespace TPCampeonatoFutbol.Modelos.Funciones
{
    public class GeneradorDeFixture
    {
        public List<CLSFecha> Generar(List<CLSEquipo> equipos, DateTime fechaInicio)
        {
            if (equipos.Count % 2 != 0)
                throw new ArgumentException("La cantidad de equipos debe ser par");

            int n = equipos.Count;
            int cantidadFechas = (n - 1) * 2;
            List<CLSFecha> fechas = new List<CLSFecha>();

            List<CLSEquipo> equiposFixture = new List<CLSEquipo>(equipos);

            int numeroFecha = 0;
            for (int vuelta = 0; vuelta < 2; vuelta++)
            {
                for (int ronda = 0; ronda < n - 1; ronda++)
                {
                    CLSFecha fecha = new CLSFecha()
                    {
                        Id = Guid.NewGuid(),
                        Dia = fechaInicio.AddDays(numeroFecha)  // asigno la fecha sumando días
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

                        CLSPartido partido = new CLSPartido()
                        {
                            Local = local.Id,
                            Visitante = visitante.Id,
                            IdFecha = fecha.Id,

                            Dia = fecha.Dia,
                            Hora = new TimeSpan(16, 0, 0),  // por ejemplo 16:00 hs
                            Estadio = local.Estadio
                        };
                        fecha.Partidos.Add(partido);
                    }

                    fechas.Add(fecha);

                    // Rotar equipos excepto el primero
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
