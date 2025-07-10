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
        private Guid _Id;

        public Guid Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        private Guid _Equipo;

        public Guid Equipo
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

        private int _Expulsiones;

        public int Expulsiones
        {
            get { return _Expulsiones; }
            set { _Expulsiones = value; }
        }

        private int _CantPartidosJugador;

        public int CantPartidosJugados
        {
            get
            {
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

        public ClSEstadisticasCampeonato()
        {
            
        }

        public ClSEstadisticasCampeonato(
            Guid equipo,
            int puntos,
            int goles,
            int expulsiones,
            int cantPartidosJugados,
            int partidosGanados,
            int partidosEmpatados,
            int partidosPerdidos)
        {
            Id = Guid.NewGuid(); 
            Equipo = equipo;
            Puntos = puntos;
            Goles = goles;
            Expulsiones = expulsiones;
            CantPartidosJugados = cantPartidosJugados;
            PartidosGanados = partidosGanados;
            PartidosEmpatados = partidosEmpatados;
            PartidosPerdidos = partidosPerdidos;
        }

        public ClSEstadisticasCampeonato(
            Guid id,
            Guid equipo,
            int puntos,
            int goles,
            int expulsiones,
            int cantPartidosJugados,
            int partidosGanados,
            int partidosEmpatados,
            int partidosPerdidos)
        {
            Id = id;
            Equipo = equipo;
            Puntos = puntos;
            Goles = goles;
            CantPartidosJugados = cantPartidosJugados;
            PartidosGanados = partidosGanados;
            PartidosEmpatados = partidosEmpatados;
            PartidosPerdidos = partidosPerdidos;
        }


    }
}
