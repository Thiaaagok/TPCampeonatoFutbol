using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using TpCampeonatoFutbolBE;
using TpCampeonatoFutbolDAL;

namespace TpCampeonatoFutbolMPP
{
    public class MPP_Usuarios
    {

        private readonly DAL_Usuarios usuarioDAL = new DAL_Usuarios();

        public List<UsuarioBE> ObtenerUsuarios()
        {
            List<UsuarioBE> listaUsuarios = new List<UsuarioBE>();
            DataTable dt = usuarioDAL.ObtenerUsuarios();
            foreach(DataRow row in dt.Rows)
            {
                Guid Id = Guid.Parse(row["Id"].ToString());
                string usuarioNombre = row["NombreUsuario"].ToString();
                byte[] contrasenia = (byte[])row["contrasenia"];
                string rol = row["Rol"].ToString();
                bool activo = (bool)row["Activo"];

                listaUsuarios.Add(new UsuarioBE(Id, usuarioNombre, contrasenia, rol, activo));
            }

            return listaUsuarios;
        }

        public bool CrearUsuario(UsuarioBE usuario)
        {
            return usuarioDAL.CrearUsuario(usuario.Id, usuario.UsuarioNombre, usuario.Contrasenia, usuario.Rol, usuario.Activo);
        }
        public UsuarioBE Login(string usuario, string contrasenia)
        {
            byte[] contraseniaBytes = System.Text.Encoding.UTF8.GetBytes(contrasenia);
            DataRow row = usuarioDAL.ObtenerUsuario(usuario, contraseniaBytes);

            return new UsuarioBE
            {
                Id = (Guid)row["Id"],
                UsuarioNombre = row["Usuario"].ToString(),
                Contrasenia = (byte[])row["Contrasenia"],
                Activo = Convert.ToBoolean(row["Activo"])
            };
        }
        
        //    public UsuarioBE ObtenerUsuarioBEPorId(int id)
        //    {
        //        DataTable dt = usuarioDAL.ObtenerUsuarioBEPorId(id);
        //        if (dt.Rows.Count == 0) return null;

        //        DataRow row = dt.Rows[0];
        //        return new UsuarioBE
        //        {
        //            Id = Guid.Parse((string)row["Id"]),
        //            UsuarioBENombre = row["UsuarioBENombre"].ToString(),
        //            Rol = row["Rol"].ToString(),
        //            Activo = Convert.ToBoolean(row["Activo"])
        //        };
        //    }
        //}
    }
}
