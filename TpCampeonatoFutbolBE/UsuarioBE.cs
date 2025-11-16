using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpCampeonatoFutbolBE
{
    public class UsuarioBE
    {
        private Guid _Id;

        public Guid Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        private string _Usuario;

        public string UsuarioNombre
        {
            get { return _Usuario; }
            set { _Usuario = value; }
        }

        private byte[] _Contrasenia;

        public byte[] Contrasenia
        {
            get { return _Contrasenia; }
            set { _Contrasenia = value; }
        }

        private string _rol;

        public string Rol
        {
            get { return _rol; }
            set { _rol = value; }
        }

        private bool _Activo;

        public bool Activo
        {
            get { return _Activo; }
            set { _Activo = value; }
        }

        public UsuarioBE()
        {
            
        }

        public UsuarioBE(Guid id, string usuarioNombre, byte[] contrasenia, string rol, bool activo)
        {
            Id = id;
            UsuarioNombre = usuarioNombre;
            Contrasenia= contrasenia;
            Rol = rol;
            Activo = activo;

        }
    }
}
