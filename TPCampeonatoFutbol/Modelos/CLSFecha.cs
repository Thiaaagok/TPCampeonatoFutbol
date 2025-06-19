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
		private string _Id;

		public string Id
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
            Util util = new Util();
            Id = util.GenerarId();
        }
        public CLSFecha(List<CLSPartido> partidos)
        {
            Util util = new Util();
            Id = util.GenerarId();
            Partidos = partidos;
        }

    }
}
