using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TpCampeonatoFutbolBE;

namespace TpCampeonatoFubolBLL
{
    public class ArbitrosBLL
    {
        public bool CrearArbitro(
   string nombre,
   string apellido,
   int edad,
   int dni,
   DateTime fechaNacimiento,
   string lugarNacimiento,
   out string mensaje,
   out ArbitroBE nuevoArbitro)
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

            nuevoArbitro = new ArbitroBE(
                Guid.NewGuid(),
                nombre,
                apellido,
                edad,
                dni,
                fechaNacimiento,
                lugarNacimiento
            );

            

            return true;
        }


        public void EditarArbitro(ArbitroBE arbitroEditado)
        {
            
        }

        public List<ArbitroBE> ObtenerTodos()
        {
            return null;

        }

        public List<ArbitroBE> BuscarPorNombre(string nombreParcial)
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
