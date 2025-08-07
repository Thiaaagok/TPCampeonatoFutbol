using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPCampeonatoFutbol.Modelos.Interfaces
{
    public interface IManejoArchivos
    {
        void CrearArchivo(string ruta);

        List<string> ObtenerTodos(string ruta);

        void GuardarTodos(string ruta, List<string> nuevosRegistros);

        void GuardarNuevo(string ruta, string nuevoRegistro);

        void EditarRegistro<T>(
            string ruta,
            Predicate<T> coincide,
            T nuevoObjeto,
            Func<T, string> convertirALinea,
            Func<string, T> convertirDesdeLinea
        );

        T ObtenerRegistroPorId<T>(
            string ruta,
            Predicate<T> coincide,
            Func<string, T> convertirDesdeLinea
        );
    }
}
