using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPCampeonatoFutbol.Servicios.Interfaces;
using TpCampeonatoFutbolBE;
using TpCampeonatoFutbolMPP;
using static TpCampeonatoFubolBLL.UsuariosBLL;

namespace TpCampeonatoFubolBLL
{
    public class UsuariosBLL
    {
            private MPP_Usuarios MPP_Usuarios = new MPP_Usuarios();
            public event NotificarInicioSesion OnInicioSesionCorrecto;
            public UsuarioBE Login(string usuario, string contrasenia)
            {
                var user = MPP_Usuarios.Login(usuario, contrasenia);

                if (user != null && user.Activo)
                {
                    OnInicioSesionCorrecto?.Invoke(user);
                }

                return user;
        }

            public bool UsuarioExiste(string nombreUsuario)
            {
                return true;
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
               

                return true;
            }

            public void editarUsuario(UsuarioBE usuarioEditado)
            {
                
                    
            }


            public List<UsuarioBE> ObtenerTodos()
            {
                return MPP_Usuarios.ObtenerUsuarios();
            }


        public delegate void NotificarInicioSesion(UsuarioBE usuario);

    }
}

