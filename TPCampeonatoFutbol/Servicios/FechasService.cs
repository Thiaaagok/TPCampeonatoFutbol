using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPCampeonatoFutbol.Funciones;
using TPCampeonatoFutbol.Modelos;

namespace TPCampeonatoFutbol.Servicios
{
    public class FechasService
    {
        private readonly ManejoArchivos manejoArchivos = new ManejoArchivos();

        public void GuardarFecha(CLSFecha fecha, int numeroFecha)
        {
            string linea = $"{fecha.Id};{numeroFecha}";
            manejoArchivos.GuardarNuevo("fechas.txt", linea);
        }

        public List<CLSFecha> CargarFechasDesdeArchivos()
        {
            var manejoArchivos = new ManejoArchivos();
            var fechasLineas = manejoArchivos.ObtenerTodos("fechas.txt");
            var partidosLineas = manejoArchivos.ObtenerTodos("partidos.txt");

            var fechas = new List<CLSFecha>();

            foreach (var linea in fechasLineas)
            {
                var partes = linea.Split(';');
                Guid idFecha = Guid.Parse(partes[0]);

                // Cargar partidos que pertenecen a esta fecha
                var partidos = partidosLineas
                    .Select(p => p.Split(';'))
                    .Where(p => Guid.Parse(p[3]) == idFecha)
                    .Select(p => new CLSPartido
                    {
                        Id = Guid.Parse(p[0]),
                        Local = Guid.Parse(p[1]),
                        Visitante = Guid.Parse(p[2]),
                        IdFecha = Guid.Parse(p[3])
                    })
                    .ToList();

                var fecha = new CLSFecha
                {
                    Id = idFecha,
                    Partidos = partidos
                };

                fechas.Add(fecha);
            }

            return fechas;
        }
    }
}
