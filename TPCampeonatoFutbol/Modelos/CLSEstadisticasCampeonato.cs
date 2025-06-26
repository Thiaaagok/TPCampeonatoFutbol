using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPCampeonatoFutbol.Modelos.Interfaces;

namespace TPCampeonatoFutbol.Modelos
{
    public class ClSEstadisticasCampeonato : IEstadisticasCampeonato
    {
        private string _Id;

        public string Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        private List<CLSPartido> _PartidosJugados;

        public List<CLSPartido> PartidosJugados
        {
            get { return _PartidosJugados; }
            set { _PartidosJugados = value; }
        }

        private CLSEquipo _Equipo;

        public CLSEquipo Equipo
        {
            get { return _Equipo; }
            set { _Equipo = value; }
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
            get
            {
                _CantPartidosJugador = PartidosJugados.Count;
                return _CantPartidosJugador;
            }
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
