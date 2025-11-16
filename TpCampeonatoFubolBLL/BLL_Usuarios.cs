using System;
using System.Collections.Generic;
using TpCampeonatoFutbolBE;
using TpCampeonatoFutbolMPP;
using static TpCampeonatoFubolBLL.UsuariosBLL;

namespace TpCampeonatoFubolBLL
{
    public class BLL_Usuarios
    {
        private readonly UsuariosDAL dal = new UsuariosDAL();
        private readonly UsuariosMPP mpp = new UsuariosMPP();

        public event NotificarInicioSesion OnInicioSesionCorrecto;

        public CLSUsuario Login(string usuario, string contrasenia)
        {
            string contraseniaHasheada = SeguridadHelper.ObtenerHash(contrasenia);
            var usuarios = mpp.MapearLista(dal.ObtenerTodos());

            var encontrado = usuarios.FirstOrDefault(u =>
                u.Usuario == usuario && u.Contrasenia == contraseniaHasheada);

            if (encontrado != null)
            {
                UsuarioGlobal.EstablecerUsuario(encontrado);
                OnInicioSesionCorrecto?.Invoke($"Inicio de sesión correcto para: {encontrado.Usuario}");
            }

            return encontrado;
        }

        public bool UsuarioExiste(string nombreUsuario)
        {
            return dal.ExisteUsuario(nombreUsuario);
        }

        public bool RegistrarUsuario(string nombreUsuario, string contrasenia, string repetirContrasenia, out string mensaje, string rol)
        {
            mensaje = "";

            if (string.IsNullOrWhiteSpace(nombreUsuario) || string.IsNullOrWhiteSpace(contrasenia))
            {
                mensaje = "Usuario y contraseña no pueden estar vacíos.";
                return false;
            }

            if (contrasenia != repetirContrasenia)
            {
                mensaje = "Las contraseñas no coinciden.";
                return false;
            }

            if (UsuarioExiste(nombreUsuario))
            {
                mensaje = "El nombre de usuario ingresado ya existe. Intenta con uno diferente.";
                return false;
            }

            string contraseniaHasheada = SeguridadHelper.ObtenerHash(contrasenia);
            CLSUsuario nuevoUsuario = new CLSUsuario(Guid.NewGuid(), nombreUsuario, contraseniaHasheada, rol);

            dal.Insertar(nuevoUsuario);
            return true;
        }

        public void EditarUsuario(CLSUsuario usuarioEditado)
        {
            if (!string.IsNullOrWhiteSpace(usuarioEditado.Contrasenia))
            {
                usuarioEditado.Contrasenia = SeguridadHelper.ObtenerHash(usuarioEditado.Contrasenia);
            }
            dal.Editar(usuarioEditado);
        }

        public List<CLSUsuario> ObtenerTodos()
        {
            return mpp.MapearLista(dal.ObtenerTodos());
        }

    }
}
