using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPCampeonatoFutbol.Modelos
{
    public class CLSFecha
    {
		private List<CLSPartido> _Partidos;

		public List<CLSPartido> Partidos
		{
			get { return _Partidos; }
			set { _Partidos = value; }
		}

	}
}
