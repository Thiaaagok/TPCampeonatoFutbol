using System;
using System.Collections.Generic;

namespace TPCampeonatoFutbol
{
    public class CLSEquipo
    {
        private string _Nombre;

        public string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }

        private string _NombreCorto;

        public string NombreCorto
        {
            get { return _NombreCorto; }
            set { _NombreCorto = value; }
        }

        private string _Ciudad;

        public string Ciudad
        {
            get { return _Ciudad; }
            set { _Ciudad = value; }
        }

        private string _Estadio;

        public string Estadio
        {
            get { return _Estadio; }
            set { _Estadio = value; }
        }

        private int _CapacidadEstadio;

        public int CapacidadEstadio
        {
            get { return _CapacidadEstadio; }
            set { _CapacidadEstadio = value; }
        }

        private int _anioFundacion;
        public int AnioFundacion
        {
            get { return _anioFundacion; }
            set { _anioFundacion = value; }
        }

        private List<CLSJugador> _jugadores;
        public List<CLSJugador> Jugadores
        {
            get { return _jugadores; }
            set { _jugadores = value; }
        }

        private ClSEstadisticasCampeonato _EstadisticasCampeonato;

        public ClSEstadisticasCampeonato EstadisticasCampeonato
        {
            get { return _EstadisticasCampeonato; }
            set { _EstadisticasCampeonato = value; }
        }


        public CLSEquipo()
        {
            Jugadores = new List<CLSJugador>();
        }

        public CLSEquipo(string nombre, string nombreCorto, string ciudad, string estadio, int capacidadEstadio, int anioFundacion)
        {
            Nombre = nombre;
            NombreCorto = nombreCorto;
            Ciudad = ciudad;
            Estadio = estadio;
            CapacidadEstadio = capacidadEstadio;
            AnioFundacion = anioFundacion;
            Jugadores = new List<CLSJugador>();
        }
    }

    public class ClSEstadisticasCampeonato
    {
        private List<CLSPartido> _PartidosJugados;

        public List<CLSPartido> PartidosJugados
        {
            get { return _PartidosJugados; }
            set { _PartidosJugados = value; }
        }

        private int _Puntos;

        public int Puntos
        {
            get { return _Puntos; }
            set { _Puntos = value; }
        }

        private int _Goles;

        public int Goles
        {
            get { return _Goles; }
            set { _Goles = value; }
        }

        private int _CantPartidosJugador;

        public int CantPartidosJugados
        {
            get {
                   _CantPartidosJugador = PartidosJugados.Count;
                   return _CantPartidosJugador; }
            set { _CantPartidosJugador = value; }
        }


        private int _PartidosGanados;

        public int PartidosGanados
        {
            get { return _PartidosGanados; }
            set { _PartidosGanados = value; }
        }

        private int _PartidosEmpatados;

        public int PartidosEmpatados
        {
            get { return _PartidosEmpatados; }
            set { _PartidosEmpatados = value; }
        }

        private int _PartidosPerdidos;

        public int PartidosPerdidos
        {
            get { return _PartidosPerdidos; }
            set { _PartidosPerdidos = value; }
        }


    }
}