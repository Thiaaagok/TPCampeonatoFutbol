using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TpCampeonatoFutbolBE;
using TpCampeonatoFutbolDAL;

namespace TpCampeonatoFutbolMPP
{
    public class MPP_Permisos
    {
        DAL_Permisos DAL_Permisos = new DAL_Permisos();
        public List<PermisoBE> ObtenerPermisos()
        {
            DataTable dt = DAL_Permisos.ObtenerPermisos();

            List<PermisoBE> permisos = new List<PermisoBE>();

            foreach (DataRow row in dt.Rows)
            {
                PermisoBE permiso = new PermisoBE()
                {
                    Id = Guid.Parse(row["Id"].ToString()),
                    Codigo = row["Codigo"].ToString(),
                    Descripcion = row["Descripcion"].ToString(),
                };

                permisos.Add(permiso);
            }

            return permisos;
        }

        public PermisoBE ObtenerPermiso(Guid id)
        {
            DataTable dt = DAL_Permisos.ObtenerPermisoPorId(id);
            if (dt.Rows.Count == 0) return null;
            DataRow row = dt.Rows[0];
            return new PermisoBE
            {
                Id = Guid.Parse(row["Id"].ToString()),
                Codigo = row["Codigo"].ToString(),
                Descripcion = row["Descripcion"].ToString(),
            };

        }

        public bool CrearPermiso(PermisoBE permiso)
        {
            return DAL_Permisos.CrearPermiso(permiso.Id,permiso.Codigo,permiso.Descripcion);
        }

        public bool EditarPermiso(PermisoBE permiso)
        {
            return DAL_Permisos.EditarPermiso(permiso.Id,permiso.Codigo, permiso.Descripcion);
        }
    }
}
