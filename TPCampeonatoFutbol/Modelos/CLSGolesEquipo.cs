using System;

namespace TPCampeonatoFutbol
{
    public class CLSGolesEquipo
    {
        private TimeSpan _Hora;

        public TimeSpan Hora
        {
            get { return _Hora; }
            set { _Hora = value; }
        }

        private string _Autor;

        public string Autor
        {
            get { return _Autor; }
            set { _Autor = value; }
        }

        private string _Equipo;

        public string Equipo
        {
            get { return _Equipo; }
            set { _Equipo = value; }
        }


    }
}