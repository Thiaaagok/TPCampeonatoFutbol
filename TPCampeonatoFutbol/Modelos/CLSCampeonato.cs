using System;
using System.Collections.Generic;
using TPCampeonatoFutbol.Modelos;
using TPCampeonatoFutbol.Modelos.Funciones;
using TPCampeonatoFutbol.Modelos.Interfaces;

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
            GeneradorDeFixture gen = new GeneradorDeFixture();
            Fechas = gen.Generar(Equipos);
        }
    }

}