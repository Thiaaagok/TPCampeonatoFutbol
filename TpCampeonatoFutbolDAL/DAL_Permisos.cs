using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpCampeonatoFutbolDAL
{
    public class DAL_Permisos
    {
        private readonly DBConexion _db = new DBConexion();

        public DataTable ObtenerPermisoPorId(Guid id)
        {
            string query = "SP_ObtenerPermisoPorId";
            Dictionary<string, object> parametros = new Dictionary<string, object>()
            {
                { "@Id", id }
            };
            return _db.Leer(query, parametros, true);
        }

        public DataTable ObtenerPermisos()
        {
            string query = "SP_ObtenerPermisos";
            return _db.Leer(query, null, true);
        }

        public bool CrearPermiso(Guid id, string codigo, string descripcion)
        {
            string query = "SP_CrearPermiso";

            var parametros = new Dictionary<string, object>()
            {
                { "@Id", id },
                { "@Codigo", codigo },
                { "@Descripcion", descripcion }
            };

            return _db.Escribir(query, parametros, true);
        }

        public bool EliminarPermiso(Guid id)
        {
            string query = "SP_EliminarPermiso";

            var parametros = new Dictionary<string, object>()
            {
                { "@Id", id }
            };

            return _db.Escribir(query, parametros, true);
        }

        public bool EditarPermiso(Guid id, string codigo, string descripcion)
        {
            string query = "SP_EditarPermiso";

            var parametros = new Dictionary<string, object>()
            {
                { "@Id", id },
                { "@Codigo", codigo },
                { "@Descripcion", descripcion }
            };

            return _db.Escribir(query, parametros, true);
        }
    }
}
