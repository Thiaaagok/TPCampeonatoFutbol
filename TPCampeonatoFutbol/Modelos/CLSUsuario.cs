using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPCampeonatoFutbol.Modelos.Funciones;

namespace TPCampeonatoFutbol.Modelos
{
    public class CLSUsuario
    {
		private string _Usuario;

		public string Usuario
		{
			get { return _Usuario; }
			set { _Usuario = value; }
		}

		private string _Contrasenia;

		public string Contrasenia
		{
			get { return _Contrasenia; }
			set { _Contrasenia = value; }
		}

        private string _Id;

        public string Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        public CLSUsuario()
        {
            Util util = new Util();
            Id = util.GenerarId();
        }

        public CLSUsuario(string usuario, string contrasenia)
        {
            this.Usuario = usuario; 
            this.Contrasenia= contrasenia;
        }

        public CLSUsuario(string id, string usuario, string contrasenia)
        {
            if (id == null)
            {
                Util util = new Util();
                Id = util.GenerarId();
            }
            else
            {
                Id = id;
            }
            this.Usuario = usuario;
            this.Contrasenia = contrasenia;
        }
    }
}
 