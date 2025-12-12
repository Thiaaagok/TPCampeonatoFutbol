using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpCampeonatoFutbolBE
{
    public class RolUsuarioBE
    {
		private Guid _Id;

		public Guid Id
		{
			get { return _Id; }
			set { _Id = value; }
		}

        private string _Codigo;

        public string Codigo
        {
            get { return _Codigo; }
            set { _Codigo = value; }
        }

        private string _Descripcion;

		public string Descripcion
		{
			get { return _Descripcion; }
			set { _Descripcion = value; }
		}

        private List<PermisoBE> _Permisos;

        public List<PermisoBE> Permisos
        {
            get { return _Permisos; }
            set { _Permisos = value; }
        }


        public RolUsuarioBE()
        {
            
        }

        public RolUsuarioBE(string cd, string dc)
        {
            Codigo = cd;
			Descripcion = dc;
        }

        public RolUsuarioBE(Guid id, string cd, string dc)
        {
            Id = id;
            Codigo = cd;
            Descripcion = dc;
        }
    }
}
