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
        private readonly DBConexion _db;

        public DataTable ObtenerArbitroPorId(string id)
        {
            string query = "SP_ObtenerArbitroPorId";
            Dictionary<string, object> parametros = new Dictionary<string, object>()
            {
                { "@Id", id }
            };
            return _db.Leer(query, parametros, true);
        }

        public DataTable obtenerArbitros()
        {
            string query = "SP_ObtenerArbitros";
            return _db.Leer(query, null, true);
        }

        public bool CrearArbitro(string id, string nombre, string apellido, string dni, int edad, DateTime fechaNacimiento, string lugarNacimiento)
        {
            string query = "SP_CrearArbitro";

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

        public bool EliminarArbitro(string id)
        {
            string query = "SP_EliminarArbitro";

            var parametros = new Dictionary<string, object>()
            {
                { "@Id", id }
            };

            return _db.Escribir(query, parametros, true);
        }

        public bool EditarArbitro(string id, string nombre, string apellido, string dni, int edad, DateTime fechaNacimiento, string lugarNacimiento)
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
