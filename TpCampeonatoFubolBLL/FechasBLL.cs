using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TpCampeonatoFutbolBE;

namespace TpCampeonatoFubolBLL
{
    public class FechasBLL
    {

        public void GuardarFecha(FechaBE fecha, int numeroFecha)
        {

        }

        public List<FechaBE> CargarFechasDesdeArchivos()
        {
            var fechas = new List<FechaBE>();

                // Cargar partidos que pertenecen a esta fecha
 
                var fecha = new FechaBE
                {
                   
                };

                fechas.Add(fecha);
            return null;
        }
    }
}
