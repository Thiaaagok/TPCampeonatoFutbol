using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPCampeonatoFutbol.Formularios.jugadores;
using TPCampeonatoFutbol.Formularios.Jugadores;
using TPCampeonatoFutbol.Formularios.Usuarios.NewFolder1;
using TpCampeonatoFutbolUI.Jugadores;
using TpCampeonatoFutbolUI.Navegacion;

namespace TpCampeonatoFutbolUI
{
    public static class FormRouter
    {
        public static Form ObtenerFormulario(RutaFormulario ruta, object parametro = null)
        {
            switch (ruta)
            {
                case RutaFormulario.Jugadores:
                    return new FRMJugadores();

                case RutaFormulario.PresentacionJugador:
                    return new FRMPresentacionJugador(Guid.Parse((string)parametro));

                default:
                    throw new Exception("Ruta no encontrada");
            }
        }
    }
}
