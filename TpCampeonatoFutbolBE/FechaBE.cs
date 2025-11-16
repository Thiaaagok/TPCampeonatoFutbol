using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpCampeonatoFutbolBE
{
    public class FechaBE
    {
		private Guid _id;

		public Guid Id
		{
			get { return _id; }
			set { _id = value; }
		}

		private List<PartidoBE> _partidos;

		public List<PartidoBE> Partidos
		{
			get { return _partidos; }
			set { _partidos = value; }
		}

	}
}
