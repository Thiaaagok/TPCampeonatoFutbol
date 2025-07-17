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

        private string _rol;

        public string Rol
        {
            get { return _rol; }
            set { _rol = value; }
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

        public CLSUsuario(Guid id, string usuario, string contrasenia, string rol)
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
            this.Rol = rol;
        }

        public void asignarPartesDesdeArray(string str)
        {
            string[] partes = str.Split(';');
            this.Id = Guid.Parse(partes[0]);
            this.Usuario = partes[1];
            this.Contrasenia = partes[2];
            this.Rol = partes[3];
        }
    }

    public class UsuarioGlobal
    {
        private static CLSUsuario _instancia;

        public static CLSUsuario Instancia
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new CLSUsuario();
                }
                return _instancia;
            }
        }

        public static void EstablecerUsuario(CLSUsuario usuario)
        {
            _instancia = usuario;
        }

        public void CerrarSesion()
        {
            _instancia = null;
        }
    }
}
 