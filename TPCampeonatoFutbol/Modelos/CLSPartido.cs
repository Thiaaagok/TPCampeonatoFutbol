using System;
using System.Collections.Generic;
using TPCampeonatoFutbol.Modelos.Funciones;
using TPCampeonatoFutbol.Modelos.Interfaces;

namespace TPCampeonatoFutbol
{
    public class CLSPartido: IPartido
    {
        private Guid _Id;

        public Guid Id
        {
            get { return _Id; }
            set { _Id = value; }

        }

        private Guid _idFecha;
        public Guid IdFecha
        {
            get { return _idFecha; }
            set { _idFecha = value; }
        }


        private DateTime _dia;
        public DateTime Dia
        {
            get { return _dia; }
            set { _dia = value; }
        }

        private TimeSpan _hora;
        public TimeSpan Hora
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

        private CLSExpulsion _Expulsiones;
        public CLSExpulsion Expulsiones
        {
            get { return _Expulsiones; }
            set { _Expulsiones = value; }
        }

        private Guid _local;
        public Guid Local
        {
            get { return _local; }
            set { _local = value; }
        }

        private Guid _visitante;
        public Guid Visitante
        {
            get { return _visitante; }
            set { _visitante = value; }
        }

        public CLSPartido()
        {
            Id = Guid.NewGuid();
        }
    }
}