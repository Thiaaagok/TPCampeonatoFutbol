using System;
using System.Collections.Generic;
using TPCampeonatoFutbol.Modelos;

namespace TPCampeonatoFutbol
{
    public class CLSCampeonato
    {
        private List<CLSPartido> _Partidos;
        public List<CLSPartido> Partidos
        {
            get { return _Partidos; }
            set { _Partidos = value; }
        }

        private List<CLSEquipo> _Equipos;

        public List<CLSEquipo> Equipos
        {
            get { return _Equipos; }
            set { _Equipos = value; }
        }
        private List<CLSFecha> _Fechas;

        public List<CLSFecha> Fechas
        {
            get { return _Fechas; }
            set { _Fechas = value; }
        }

        private static readonly Lazy<CLSCampeonato> instancia = new Lazy<CLSCampeonato>(() => new CLSCampeonato());

        private CLSCampeonato()
        {
            Partidos = new List<CLSPartido>();
            Equipos = new List<CLSEquipo>();
            Fechas = new List<CLSFecha>();
        }

        public static CLSCampeonato Instancia => instancia.Value;

        public void GenerarCampeonato()
        {
            Random rand = new Random();

            if(Equipos.Count % 2 != 0)
            {
                throw new ArgumentException("la cantidad de equipos debe ser par");
            }

            int cantidadFechas = (Equipos.Count * 2) - 2;
            List<CLSEquipo> EquipoOriginal = new List<CLSEquipo>(Equipos);

            for (int i = 0; i < cantidadFechas; i++)
            {
                CLSFecha fecha = new CLSFecha();

                List<CLSEquipo> EquiposDisponibles = new List<CLSEquipo>(EquipoOriginal);
                int index1 = rand.Next(Equipos.Count);
                CLSEquipo equipo1 = EquiposDisponibles[index1];
                EquiposDisponibles.RemoveAt(index1);

                int index2 = rand.Next(Equipos.Count);
                CLSEquipo equipo2 = EquiposDisponibles[index2];
                EquiposDisponibles.RemoveAt(index2);

                if(i % 2 == 0)
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

                CLSCampeonato.Instancia.Fechas.Add(fecha);
            }
        }
    }

}