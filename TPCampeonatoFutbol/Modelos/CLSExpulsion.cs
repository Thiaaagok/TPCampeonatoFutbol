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

        private int _Minutos;

        public int Minutos
        {
            get { return _Minutos; }
            set { _Minutos = value; }
        }

        private Guid _AutorId;

        public Guid AutorId
        {
            get { return _AutorId; }
            set { _AutorId = value; }
        }

        private string _Autor;

        public string Autor
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

        public CLSExpulsion()
        {
            
        }

        public CLSExpulsion(Guid partidoId, Guid equipoId, Guid autorId, string autor, int minutos, string causa)
        { 
            Id = Guid.NewGuid();
            PartidoId = partidoId;
            EquipoId = equipoId;
            AutorId = autorId;
            Autor = autor;
            Minutos = minutos;
            Causa = causa;
        }

        public CLSExpulsion(Guid id,Guid partidoId, Guid equipoId, Guid autorId,string autor, int minutos, string causa)
        {
            Id = id;
            PartidoId = partidoId;
            EquipoId = equipoId;
            AutorId = autorId;
            Autor = autor;
            Minutos = minutos;
            Causa = causa;
        }
    }
}