using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPCampeonatoFutbol.Modelos.Funciones;

namespace TPCampeonatoFutbol.Modelos
{
    public class CLSFecha
    {
		private Guid _Id;

		public Guid Id
		{
			get { return _Id; }
			set { _Id = value; }
		}

		private List<CLSPartido> _Partidos;

		public List<CLSPartido> Partidos
		{
			get { return _Partidos; }
			set { _Partidos = value; }
		}
        public CLSFecha()
        {
            Id = Guid.NewGuid();
            Partidos = new List<CLSPartido>();
        }
        public CLSFecha(List<CLSPartido> partidos)
        {
            Id = Guid.NewGuid();
            Partidos = partidos;
        }

    }
}
