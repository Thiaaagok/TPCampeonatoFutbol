using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TpCampeonatoFutbolUI.Navegacion;

namespace TpCampeonatoFutbolUI
{
    public class NavegacionService
    {
        public Action<RutaFormulario, object> Navegar;

        private static NavegacionService instance;

        public static NavegacionService Instance
        {
            get
            {
                if (instance == null)
                    instance = new NavegacionService();

                return instance;
            }
        }
    }
}
