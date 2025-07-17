using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPCampeonatoFutbol.Funciones;
using TPCampeonatoFutbol.Modelos;
using TPCampeonatoFutbol.Servicios.Interfaces;

namespace TPCampeonatoFutbol.Servicios
{
    public class UsuarioService: IUsuariosService
    {
        private readonly ManejoArchivos manejoArchivos = new ManejoArchivos();
        private readonly string ruta = "usuarios.txt";

        public event NotificarInicioSesion OnInicioSesionCorrecto;
        public CLSUsuario Login(string usuario, string contrasenia)
        {
            var lineas = manejoArchivos.ObtenerTodos("usuarios.txt");

            foreach (var linea in lineas)
            {
                var usuarioVerificar = new CLSUsuario();
                usuarioVerificar.asignarPartesDesdeArray(linea);

                if (usuarioVerificar.Usuario == usuario &&
                    usuarioVerificar.Contrasenia == contrasenia)
                {
                    UsuarioGlobal.EstablecerUsuario(usuarioVerificar);

                    OnInicioSesionCorrecto?.Invoke($"Inicio de sesión correcto para: {usuarioVerificar.Usuario}");

                    return usuarioVerificar;
                }
            }

            return null;
        }

        public bool UsuarioExiste(string nombreUsuario)
        {
            var usuarios = manejoArchivos.ObtenerTodos(ruta);
            return usuarios.Any(linea =>
            {
                var partes = linea.Split(',');
                return partes.Length >= 1 && partes[1] == nombreUsuario;
            });
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

            CLSUsuario nuevoUsuario = new CLSUsuario(Guid.NewGuid(), nombreUsuario, contrasenia, rol);
            string nuevoRegistro = $"{nuevoUsuario.Id};{nuevoUsuario.Usuario};{nuevoUsuario.Contrasenia};{nuevoUsuario.Rol}";
            manejoArchivos.GuardarNuevo(ruta, nuevoRegistro);

            return true;
        }

        public void editarUsuario(CLSUsuario usuarioEditado)
        {
            ManejoArchivos archivos = new ManejoArchivos();

            archivos.EditarRegistro<CLSUsuario>(
                ruta, 
                u => u.Id == usuarioEditado.Id,
                usuarioEditado,
                usuario => $"{usuario.Id};{usuario.Usuario};{usuario.Contrasenia};{usuario.Rol}",
                linea =>
                {
                    var partes = linea.Split(';');
                    return new CLSUsuario(
                        Guid.Parse(partes[0]),
                        partes[1],
                        partes[2],
                        partes[3]
                    );
                }
            );
        }


        public List<CLSUsuario> ObtenerTodos()
        {
            try
            {
                List<string> lineas = manejoArchivos.ObtenerTodos(ruta);
                List<CLSUsuario> jugadores = new List<CLSUsuario>();

                foreach (var linea in lineas)
                {
                    var partes = linea.Split(';');

                    CLSUsuario jugador = new CLSUsuario(
                        Guid.Parse(
                        partes[0]),
                        partes[1],
                        partes[2],
                        partes[3]
                    );

                    jugadores.Add(jugador);
                }

                return jugadores;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }

    public delegate void NotificarInicioSesion(string mensaje);

}
