using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPCampeonatoFutbol.Funciones;
using TPCampeonatoFutbol.Modelos;

namespace TPCampeonatoFutbol.Servicios
{
    public class ArbitroService
    {
        private readonly ManejoArchivos manejoArchivos = new ManejoArchivos();
        private readonly string ruta = "arbitros.txt";
        public bool CrearArbitro(
    string nombre,
    string apellido,
    int edad,
    int dni,
    DateTime fechaNacimiento,
    string lugarNacimiento,
    out string mensaje,
    out CLSArbitro nuevoArbitro)
        {
            mensaje = "";
            nuevoArbitro = null;

            if (string.IsNullOrWhiteSpace(nombre) ||
                string.IsNullOrWhiteSpace(apellido) ||
                edad <= 0 ||
                dni <= 0 ||
                string.IsNullOrWhiteSpace(lugarNacimiento))
            {
                mensaje = "Por favor, completa todos los campos correctamente.";
                return false;
            }

            nuevoArbitro = new CLSArbitro(
                Guid.NewGuid(),
                nombre,
                apellido,
                edad,
                dni,
                fechaNacimiento,
                lugarNacimiento
            );

            string nuevaLinea = $"{nuevoArbitro.Id};{nuevoArbitro.Nombre};{nuevoArbitro.Apellido};{nuevoArbitro.Edad};{nuevoArbitro.Dni};{nuevoArbitro.FechaNacimiento:dd/MM/yyyy HH:mm:ss};{nuevoArbitro.LugarNacimiento}";

            manejoArchivos.GuardarNuevo(ruta, nuevaLinea);

            return true;
        }


        public void EditarArbitro(CLSArbitro arbitroEditado)
        {
            ManejoArchivos archivos = new ManejoArchivos();

            archivos.EditarRegistro<CLSArbitro>(
                ruta,
                a => a.Id == arbitroEditado.Id,
                arbitroEditado,
                arbitro => $"{arbitro.Id};{arbitro.Nombre};{arbitro.Apellido};{arbitro.Edad};{arbitro.Dni};{arbitro.FechaNacimiento:dd/MM/yyyy HH:mm:ss};{arbitro.LugarNacimiento}",
                linea =>
                {
                    var partes = linea.Split(';');

                    return new CLSArbitro(
                        Guid.Parse(partes[0]),
                        partes[1],
                        partes[2],
                        int.Parse(partes[3]),
                        int.Parse(partes[4]),
                        DateTime.ParseExact(partes[5], "dd/MM/yyyy HH:mm:ss", null),
                        partes[6]
                    );
                }
            );
        }

        public List<CLSArbitro> ObtenerTodos()
        {
            try
            {
                List<string> lineas = manejoArchivos.ObtenerTodos(ruta);
                List<CLSArbitro> arbitros = new List<CLSArbitro>();

                foreach (var linea in lineas)
                {
                    var partes = linea.Split(';');

                    CLSArbitro arbitro = new CLSArbitro(
                        Guid.Parse(partes[0]),
                        partes[1],
                        partes[2],
                        int.Parse(partes[3]),
                        int.Parse(partes[4]),
                        DateTime.ParseExact(partes[5], "dd/MM/yyyy HH:mm:ss", null),
                        partes[6]
                    );

                    arbitros.Add(arbitro);
                }

                return arbitros;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<CLSArbitro> BuscarPorNombre(string nombreParcial)
        {
            return ObtenerTodos()
                .Where(a => a.Nombre.ToLower().Contains(nombreParcial.ToLower()))
            .ToList();
        }

        public bool ExisteArbitroPorDNI(int dni)
        {
            return ObtenerTodos()
                .Any(a => a.Dni == dni);
        }

    }

}
