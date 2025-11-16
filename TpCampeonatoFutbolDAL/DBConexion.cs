using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace TpCampeonatoFutbolDAL
{
    public class DBConexion
    {
        private readonly string _connectionString = "Server=NOTEBOOKTHIAGO\\MSSQLSERVER01;Database=TPCampeonatoFutbol;Trusted_Connection=True;";

        public DBConexion()
        {

        }

        public void Conectar()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
            }

        }

        public DataTable Leer(string query, Dictionary<string, object> parametros = null)
        {
            using (var connection = new SqlConnection(_connectionString))
            using (var command = new SqlCommand(query, connection))
            {
                if (parametros != null)
                {
                    foreach (var p in parametros)
                        command.Parameters.AddWithValue(p.Key, p.Value ?? DBNull.Value);
                }

                using (var adapter = new SqlDataAdapter(command))
                {
                    var dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
            }
        }

        public int Escribir(string query, Dictionary<string, object> parametros = null)
        {
            using (var connection = new SqlConnection(_connectionString))
            using (var command = new SqlCommand(query, connection))
            {
                if (parametros != null)
                {
                    foreach (var p in parametros)
                        command.Parameters.AddWithValue(p.Key, p.Value ?? DBNull.Value);
                }

                connection.Open();
                return command.ExecuteNonQuery();
            }
        }
        public int Eliminar(string tabla, string idColumna, object idValor)
        {
            string query = $"DELETE FROM {tabla} WHERE {idColumna} = @{idColumna}";
            var parametros = new Dictionary<string, object>
        {
            { $"@{idColumna}", idValor }
        };

            return Escribir(query, parametros);
        }

        public int Editar(string tabla, string idColumna, object idValor, Dictionary<string, object> nuevosValores)
        {
            if (nuevosValores == null || nuevosValores.Count == 0)
                throw new ArgumentException("Debe proporcionar al menos un campo a actualizar.", nameof(nuevosValores));

            var setPartes = new List<string>();
            foreach (var campo in nuevosValores.Keys)
            {
                setPartes.Add($"{campo} = @{campo}");
            }

            string setQuery = string.Join(", ", setPartes);
            string query = $"UPDATE {tabla} SET {setQuery} WHERE {idColumna} = @{idColumna}";
            nuevosValores.Add($"@{idColumna}", idValor);

            return Escribir(query, nuevosValores);
        }
    }
}
