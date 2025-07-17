using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPCampeonatoFutbol.Modelos
{
    public class CLSPartidoResultado
    {
		private Guid _PartidoId;

		public Guid PartidoId
		{
			get { return _PartidoId; }
			set { _PartidoId = value; }
		}

		private int _GolesLocal;

		public int GolesLocal
		{
			get { return _GolesLocal; }
			set { _GolesLocal = value; }
		}

		private int _GolesVisitante;

		public int GolesVisitante
		{
			get { return _GolesVisitante; }
			set { _GolesVisitante = value; }
		}

		private int _ExpulsionesLocal;

		public int ExpulsionesLocal
        {
			get { return _ExpulsionesLocal; }
			set { _ExpulsionesLocal = value; }
		}

        private int _ExpulsionesVisitante;

        public int ExpulsionesVisitante
        {
            get { return _ExpulsionesVisitante; }
            set { _ExpulsionesVisitante = value; }
        }

        public CLSPartidoResultado()
        {
			
        }

        public CLSPartidoResultado(Guid partidoId, int gl, int gv, int el, int ev)
        {
			PartidoId = partidoId;
			GolesLocal = gl;
			GolesVisitante = gv;
			ExpulsionesLocal = el;
			ExpulsionesVisitante = ev;
        }



    }
}
