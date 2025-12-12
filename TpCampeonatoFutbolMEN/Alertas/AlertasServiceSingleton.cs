using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpCampeonatoFutbolMEN.Alertas
{
    public sealed class AlertasServiceSingleton
    {
        private static readonly Lazy<IAlertasService> _instance =
            new Lazy<IAlertasService>(() => new AlertService());

        public static IAlertasService Instance => _instance.Value;
    }
}
