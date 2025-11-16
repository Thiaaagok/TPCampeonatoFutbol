using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpCampeonatoFutbolDAL
{
    public class DAL_Equipos
    {
        SqlConnection connectionDb = new SqlConnection();
        DBConexion conexion = new DBConexion();
        public DAL_Equipos()
        {
        }

        public DataTable ObtenerEquipos()
        {
            using (var command = new SqlCommand("SELECT * FROM Usuarios", connectionDb))
            using (var adapter = new SqlDataAdapter(command))
            {
                var tabla = new DataTable();
                adapter.Fill(tabla);
                return tabla;
            }
        }
    }
}
