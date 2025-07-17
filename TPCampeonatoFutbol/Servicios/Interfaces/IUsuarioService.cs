using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPCampeonatoFutbol.Modelos;

namespace TPCampeonatoFutbol.Servicios.Interfaces
{
    public interface IUsuariosService
    {
        CLSUsuario Login(string usuario, string contrasenia);

        bool UsuarioExiste(string nombreUsuario);

        bool RegistrarUsuario(string nombreUsuario, string contrasenia, string repetirContrasenia, out string mensaje, string rol);

        void editarUsuario(CLSUsuario usuarioEditado);

        List<CLSUsuario> ObtenerTodos();
    }
}
