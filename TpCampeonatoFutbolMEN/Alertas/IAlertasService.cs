using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpCampeonatoFutbolMEN
{
    public interface IAlertasService
    {
        void Info(string mensaje);
        void Exito(string mensaje);
        void Advertencia(string mensaje);
        void Error(string mensaje);
        void Error(Exception ex);
    }
}
