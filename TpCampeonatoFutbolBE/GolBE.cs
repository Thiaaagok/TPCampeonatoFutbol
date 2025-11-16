using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpCampeonatoFutbolBE
{
    public class GolBE
    {
		private Guid _autorId;

		public Guid AutorId
		{
			get { return _autorId; }
			set { _autorId = value; }
		}

		private Guid _equipoId;

		public Guid EquipoId
		{
			get { return _equipoId; }
			set { _equipoId = value; }
		}

		private Guid _id;

		public Guid Id
		{
			get { return _id; }
			set { _id = value; }
		}

		private Guid _partidoId;

		public Guid PartidoId
		{
			get { return _partidoId; }
			set { _partidoId = value; }
		}

		private int myVar;

		public int MyProperty
		{
			get { return myVar; }
			set { myVar = value; }
		}

        public GolBE()
        {
				
        }


        public GolBE(Guid partidoId, Guid autorId, Guid autor, Guid equipoId)
        {
            Id = Guid.NewGuid();
            PartidoId = partidoId;
            AutorId = autor;
            EquipoId = equipoId;
        }

        public GolBE(Guid id, Guid partidoId, Guid autorId, Guid autor, Guid equipoId)
        {
            Id = id;
            PartidoId = partidoId;
            AutorId = autorId;
            AutorId = autor;
            EquipoId = equipoId;
        }

    }
}
