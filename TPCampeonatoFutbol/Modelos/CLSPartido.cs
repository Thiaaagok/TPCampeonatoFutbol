using System;
using System.Collections.Generic;
using TPCampeonatoFutbol.Modelos.Interfaces;

namespace TPCampeonatoFutbol
{
    public class CLSPartido: IPartido
    {
        private DateTime _dia;
        public DateTime Dia
        {
            get { return _dia; }
            set { _dia = value; }
        }

        private DateTime _hora;
        public DateTime Hora
        {
            get { return _hora; }
            set { _hora = value; }
        }

        private string _estadio;
        public string Estadio
        {
            get { return _estadio; }
            set { _estadio = value; }
        }

        private CLSPersona _arbitro;
        public CLSPersona Arbitro
        {
            get { return _arbitro; }
            set { _arbitro = value; }
        }

        private CLSGolesEquipo _goles;
        public CLSGolesEquipo Goles
        {
            get { return _goles; }
            set { _goles = value; }
        }

        private CLSEquipo _local;
        public CLSEquipo Local
        {
            get { return _local; }
            set { _local = value; }
        }

        private CLSEquipo _visitante;
        public CLSEquipo Visitante
        {
            get { return _visitante; }
            set { _visitante = value; }
        }
    }
}