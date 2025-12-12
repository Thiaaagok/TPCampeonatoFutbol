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
    public class MPP_Jugadores
    {
        DAL_Jugadores DAL_Jugadores = new DAL_Jugadores();
        public List<JugadorBE> ObtenerJugadores()
        {
            DataTable dt = DAL_Jugadores.ObtenerJugadores();

            List<JugadorBE> jugadores = new List<JugadorBE>();

            foreach (DataRow row in dt.Rows)
            {
                JugadorBE jugador = new JugadorBE()
                {
                    Id = Guid.Parse(row["Id"].ToString()),
                    Nombre = row["Nombre"].ToString(),
                    Apellido = row["Apellido"].ToString(),
                    Dni = row["DNI"].ToString(),
                    EquipoNombre = row["EquipoNombre"].ToString()
                };

                jugadores.Add(jugador);
            }

            return jugadores;
        }

        public JugadorBE ObtenerJugador(Guid id)
        {
            DataTable dt = DAL_Jugadores.ObtenerJugadorPorId(id);
            if (dt.Rows.Count == 0) return null;

            DataRow row = dt.Rows[0];
            return new JugadorBE
            {
                Id = (Guid)row["Id"],
                Nombre = row["Nombre"].ToString(),
                Apellido = row["Apellido"].ToString(),
                Dni = row["DNI"].ToString(),
                RolId = Guid.Parse(row["RolJugadorId"].ToString()),
                Edad = Convert.ToInt32(row["Edad"]),
                FechaNacimiento = Convert.ToDateTime(row["FechaNacimiento"].ToString()),
                LugarNacimiento = row["LugarNacimiento"].ToString(),
                EquipoId = Guid.Parse(row["EquipoId"].ToString()),
                EquipoNombre = row["EquipoNombre"].ToString(),
                Foto = row["Foto"].ToString(),
                Goles = Convert.ToInt32(row["Edad"]),
                TarjetasAmarillas = Convert.ToInt32(row["TarjetasAmarillas"]),
                TarjetasRojas = Convert.ToInt32(row["TarjetasRojas"]),
                Precio = Convert.ToDecimal(row["Precio"])
            };
        }

    }
}