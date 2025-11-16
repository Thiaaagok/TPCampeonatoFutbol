using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpCampeonatoFutbolDAL
{
    public class DAL_Usuarios
    {
        private readonly DBConexion _db;

        public DataTable ObtenerUsuarioPorId(string dni)
        {
            string query = "SP_ObtenerUsuarioPorId";
            Dictionary<string, object> parametros = new Dictionary<string, object>()
            {
                { "@DNI", dni }
            };
            return _db.Leer(query, parametros, true);
        }

        public DataTable obtenerUsuarios()
        {
            string query = "SP_ObtenerUsuarios";
            return _db.Leer(query, null, true);
        }

        public bool CrearUsuario(string id, string contrasenia, string usuarioNombre, string idRol)
        {
            string query = "SP_CrearUsuario";

            var parametros = new Dictionary<string, object>()
            {
                { "@Id", id },
                { "@Contrasenia", contrasenia },
                { "@UsuarioNombre", usuarioNombre },
                { "@IdRol", idRol }
            };

            return _db.Escribir(query, parametros, true);
        }

        public bool EliminarUsuario(string id)
        {
            string query = "SP_EliminarUsuario";

            var parametros = new Dictionary<string, object>()
            {
                { "@Id", id }
            };

            return _db.Escribir(query, parametros, true);
        }

        public bool EditarUsuario(string id, string contrasenia, string usuarioNombre, string idRol)
        {
            string query = "SP_EditarUsuario";

            var parametros = new Dictionary<string, object>()
            {
                { "@Id", id },
                { "@Contrasenia", contrasenia },
                { "@UsuarioNombre", usuarioNombre },
                { "@IdRol", idRol }
            };

            return _db.Escribir(query, parametros, true);
        }
    }
}
