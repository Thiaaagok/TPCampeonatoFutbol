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

        private Guid _Id;

        public Guid Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        public CLSUsuario()
        {
            Id = Guid.NewGuid();
        }

        public CLSUsuario(string usuario, string contrasenia)
        {
            this.Usuario = usuario; 
            this.Contrasenia= contrasenia;
        }

        public CLSUsuario(Guid id, string usuario, string contrasenia)
        {
            if (id == null)
            {
                Id = Guid.NewGuid();
            }
            else
            {
                Id = id;
            }
            this.Usuario = usuario;
            this.Contrasenia = contrasenia;
        }

        public void asignarPartesDesdeArray(string str)
        {
            string[] partes = str.Split(';');
            this.Id = Guid.Parse(partes[0]);
            this.Usuario = partes[1];
            this.Contrasenia = partes[2];
        }
    }
}
 