using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TpCampeonatoFutbolBE;
using TpCampeonatoFutbolMPP;

namespace TpCampeonatoFubolBLL
{
    public class BLL_Permisos
    {
        MPP_Permisos MPP_Permisos = new MPP_Permisos();
        public List<PermisoBE> ObtenerTodos()
        {
            return MPP_Permisos.ObtenerPermisos();
        }

        public PermisoBE ObtenerPermiso(Guid id)
        {
            return MPP_Permisos.ObtenerPermiso(id);
        }

        public bool CrearPermiso(PermisoBE permiso)
        {
            permiso.Id = Guid.NewGuid();
            return MPP_Permisos.CrearPermiso(permiso);
        }

        public bool EditarPermiso(PermisoBE permiso)
        {
            return MPP_Permisos.EditarPermiso(permiso);
        }
    }
}
