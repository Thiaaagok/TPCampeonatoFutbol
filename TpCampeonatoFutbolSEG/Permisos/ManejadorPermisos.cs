using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpCampeonatoFutbolSEG.Permisos
{
    public class ManejadorPermisos
    {
        private static readonly Dictionary<string, HashSet<PermisosEnum>> _permisosPorRol
        = new Dictionary<string, HashSet<PermisosEnum>>();

        static ManejadorPermisos()
        {
            _permisosPorRol["ADMIN"] = new HashSet<PermisosEnum>
        {
            PermisosEnum.VerJugadores,
            PermisosEnum.EditarJugador,
            PermisosEnum.BorrarJugador,
            PermisosEnum.NavegarEstadisticas,
            PermisosEnum.NavegarJugadores
        };

            _permisosPorRol["JUGADOR"] = new HashSet<PermisosEnum>
        {
            PermisosEnum.VerJugadores,
            PermisosEnum.NavegarJugadores
        };

            _permisosPorRol["DIRECTORTECNICO"] = new HashSet<PermisosEnum>
        {
            PermisosEnum.VerJugadores
        };

        }

        public static bool TienePermiso(PermisosEnum permiso)
        {
            var rol = UsuarioSesion.Instancia.Rol.ToString();
            if (rol == null) return false;

            if (!_permisosPorRol.ContainsKey(rol))
                return false;

            return _permisosPorRol[rol].Contains(permiso);
        }
    }
}