using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace TpCampeonatoFutbolDAL
{
    public class DBConexion
    {
        private readonly string _connectionString = "Server=localhost;Database=TPCampeonatoFutbol;Trusted_Connection=True;";

        private SqlConnection iniciarConexion()
        {
            var conexion = new SqlConnection(_connectionString);
            conexion.Open();
            return conexion;
        }

        public DataTable Leer(string query, Dictionary<string, object> parametros = null, bool StoredProcedure = false)
        {
            using (SqlConnection connection = iniciarConexion())
            {
                using (SqlCommand cm = new SqlCommand(query, connection))
                {
                    if (StoredProcedure)
                        cm.CommandType = CommandType.StoredProcedure;

                    if (parametros != null)
                    {
                        foreach (var p in parametros)
                            cm.Parameters.AddWithValue(p.Key, p.Value ?? DBNull.Value);
                    }

                    using (SqlDataAdapter da = new SqlDataAdapter(cm))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        return dt;
                    }
                }
            }
        }


        public bool Escribir(string query, Dictionary<string, object> parametros = null, bool StoredProcedure = false)
        {
            using (SqlConnection connection = iniciarConexion())
            {
                using (SqlCommand cm = new SqlCommand(query, connection))
                {
                    if (StoredProcedure)
                        cm.CommandType = CommandType.StoredProcedure;

                    if (parametros != null)
                    {
                        foreach (var p in parametros)
                            cm.Parameters.AddWithValue(p.Key, p.Value ?? DBNull.Value);
                    }

                    return cm.ExecuteNonQuery() > 0;
                }
            }
        }
    }
}
