using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpCampeonatoFutbolDAL
{
    public class DAL_Jugadores
    {
        private readonly DBConexion _db = new DBConexion();

        public DataTable ObtenerJugadorPorId(Guid id)
        {
            string query = "SP_ObtenerArbitroPorId";
            Dictionary<string, object> parametros = new Dictionary<string, object>()
            {
                { "@Id", id }
            };
            return _db.Leer(query, parametros, true);
        }

        public DataTable ObtenerJugadores()
        {
            string query = "SP_ObtenerJugadores";
            return _db.Leer(query, null, true);
        }

        public bool CrearJugador(Guid id,Guid equipoId,Guid rolJugadorId, string nombre, string apellido, string dni, int edad, DateTime fechaNacimiento, string lugarNacimiento, string foto, string equipoNombre)
        {
            string query = "SP_CrearJugador";

            var parametros = new Dictionary<string, object>()
            {
                { "@Id", id },
                { "@Nombre", nombre },
                { "@Apellido", apellido },
                { "@DNI", dni },
                { "@Edad", edad },
                { "@FechaNacimiento", fechaNacimiento },
                { "@LugarNacimiento", lugarNacimiento },
                { "@Foto", foto },
                { "@EquipoNombre", equipoNombre }
            };

            return _db.Escribir(query, parametros, true);
        }

        public bool EliminarJugador(string id)
        {
            string query = "SP_EliminarArbitro";

            var parametros = new Dictionary<string, object>()
            {
                { "@Id", id }
            };

            return _db.Escribir(query, parametros, true);
        }

        public bool EditarJugador(string id, string nombre, string apellido, string dni, int edad, DateTime fechaNacimiento, string lugarNacimiento)
        {
            string query = "SP_EditarArbitro";

            var parametros = new Dictionary<string, object>()
            {
                { "@Id", id },
                { "@Nombre", nombre },
                { "@Apellido", apellido },
                { "@DNI", dni },
                { "Edad", edad },
                { "FechaNacimiento", fechaNacimiento },
                { "LugarNacimiento", lugarNacimiento }
            };

            return _db.Escribir(query, parametros, true);
        }   

    }
}
