using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPCampeonatoFutbol;
using TpCampeonatoFutbolMEN.Alertas;

namespace TpCampeonatoFutbolUI
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.ThreadException += (s, e) =>
            {
                AlertasServiceSingleton.Instance.Error(e.Exception);
            };
            Application.Run(new FRMLogin());
        }
    }
}
