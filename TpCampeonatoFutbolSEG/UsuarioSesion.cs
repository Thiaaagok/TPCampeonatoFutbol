using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TpCampeonatoFutbolSEG.Permisos;

namespace TpCampeonatoFutbolSEG
{
    public enum Rol
    {
        Administrador,
        Operador,
        Invitado
    }
    public sealed class UsuarioSesion
        {
            private static readonly Lazy<UsuarioSesion> _instancia =
                new Lazy<UsuarioSesion>(() => new UsuarioSesion());

            public static UsuarioSesion Instancia => _instancia.Value;

            public int UserId { get; private set; }
            public string Nombre { get; private set; }
            public Rol? Rol { get; private set; }

            private readonly HashSet<PermisosEnum> _permisos = new HashSet<PermisosEnum>();

            private UsuarioSesion() { }

            public void IniciarSesion(int userId, string nombre, Rol rol, IEnumerable<PermisosEnum> permisos)
            {
                UserId = userId;
                Nombre = nombre;
                Rol = rol;

                _permisos.Clear();
                foreach (var p in permisos)
                    _permisos.Add(p);
            }

            public bool TienePermiso(PermisosEnum permiso)
            {
                return _permisos.Contains(permiso);
            }

            public IReadOnlyCollection<PermisosEnum> ObtenerPermisos()
            {
                return _permisos.ToList().AsReadOnly();
            }

            public void CerrarSesion()
            {
                UserId = 0;
                Nombre = string.Empty;
                Rol = null;
                _permisos.Clear();
            }
        }
}
