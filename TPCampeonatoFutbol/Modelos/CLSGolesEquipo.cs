﻿using System;

namespace TPCampeonatoFutbol
{
    public class CLSGolesEquipo
    {
        private DateTime _Hora;

        public DateTime Hora
        {
            get { return _Hora; }
            set { _Hora = value; }
        }

        private CLSJugador _Autor;

        public CLSJugador Autor
        {
            get { return _Autor; }
            set { _Autor = value; }
        }

        private CLSEquipo _Equipo;

        public CLSEquipo Equipo
        {
            get { return _Equipo; }
            set { _Equipo = value; }
        }


    }
}