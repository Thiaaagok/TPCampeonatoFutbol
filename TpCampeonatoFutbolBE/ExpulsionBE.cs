using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpCampeonatoFutbolBE
{
    public class ExpulsionBE
    {
		private string _causa;

		public string Causa
		{
			get { return _causa; }
			set { _causa = value; }
		}

		private Guid _jugadorExpulsadoId;

		public Guid JugadorExpulsadoId
		{
			get { return _jugadorExpulsadoId; }
			set { _jugadorExpulsadoId = value; }
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

        private Guid _equipoId;

        public Guid EquipoId
        {
            get { return _equipoId; }
            set { _equipoId = value; }
        }



        public ExpulsionBE()
        {

        }

        public ExpulsionBE(Guid partidoId, Guid equipoId, Guid jugadorExpulsadoId, string causa)
        {
            Id = Guid.NewGuid();
            PartidoId = partidoId;
            EquipoId = equipoId;
            JugadorExpulsadoId = jugadorExpulsadoId;
            Causa = causa;
        }

        public ExpulsionBE(Guid id, Guid partidoId, Guid equipoId, Guid autorId, Guid jugadorExpulsadoId, string causa)
        {
            Id = id;
            PartidoId = partidoId;
            EquipoId = equipoId;
            JugadorExpulsadoId = jugadorExpulsadoId;
            Causa = causa;
        }
    }
}
