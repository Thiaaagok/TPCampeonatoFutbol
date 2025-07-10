using System;

namespace TPCampeonatoFutbol
{
    public class CLSGolesEquipo
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


        public CLSGolesEquipo()
        {
               Id = Guid.NewGuid();
        }

        public CLSGolesEquipo(Guid partidoId, Guid autorId,string autor, Guid equipoId, int minutos)
        {
            Id = Guid.NewGuid();
            PartidoId = partidoId;
            AutorId = autorId;
            Autor = autor;
            EquipoId = equipoId;
            Minutos = minutos;
        }

        public CLSGolesEquipo(Guid id, Guid partidoId, Guid autorId, string autor, Guid equipoId, int minutos)
        {
            Id = id;
            PartidoId = partidoId;
            AutorId = autorId;
            Autor = autor;
            EquipoId = equipoId;
            Minutos = minutos;
        }
    }
}