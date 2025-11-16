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

        public DataTable ObtenerUsuarios()
        {
            string query = "SELECT * FROM Usuarios";
            return _db.Leer(query);
        }

        public bool CrearUsuario(Guid id, string usuarioNombre, byte[] contrasenia, string rol, bool activo)
        {
            string query = "INSERT INTO Usuarios (Id, UsuarioNombre, Contrasenia, Rol, Activo) " +
                           "VALUES (@Id, @UsuarioNombre, @Contrasenia, @Rol, @Activo)";

            var parametros = new Dictionary<string, object>
            {
                { "@Id", id },
                { "@UsuarioNombre", usuarioNombre },
                { "@Contrasenia", contrasenia },
                { "@Rol", rol },
                { "@Activo", activo }
            };

            return _db.Escribir(query, parametros) > 0;
        }

        public DataRow ObtenerUsuario(string usuario, byte[] contrasenia)
        {
            string query = "SELECT Id, Usuario, Contrasenia, Activo " +
                           "FROM Usuarios " +
                           "WHERE Usuario = @usuario AND Contrasenia = @contrasenia";

            var parametros = new Dictionary<string, object>
        {
            {"@usuario", usuario},
            {"@contrasenia", contrasenia}
        };

            var dt = _db.Leer(query, parametros);

            if (dt.Rows.Count == 0)
                return null;

            DataRow row = dt.Rows[0];
            return row; 
        }
    }
}
