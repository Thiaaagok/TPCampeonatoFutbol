using System;

namespace TPCampeonatoFutbol
{
    public class CLSExpulsion
    {
        private Guid _Id;

        public Guid Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        private TimeSpan _Minutos;

        public TimeSpan Minutos
        {
            get { return _Minutos; }
            set { _Minutos = value; }
        }

        private Guid _Autor;

        public Guid Autor
        {
            get { return _Autor; }
            set { _Autor = value; }
        }

        private Guid _EquipoId;

        public Guid EquipoId
        {
            get { return _EquipoId; }
            set { _EquipoId = value; }
        }

        private Guid _PartidoId;

        public Guid PartidoId
        {
            get { return _PartidoId; }
            set { _PartidoId = value; }
        }

        private string _Causa;

        public string Causa
        {
            get { return _Causa; }
            set { _Causa = value; }
        }


    }
}