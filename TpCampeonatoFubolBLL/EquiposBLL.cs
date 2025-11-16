using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPCampeonatoFutbol;
using TpCampeonatoFutbolBE;

namespace TpCampeonatoFubolBLL
{
    public class EquiposBLL
    {
        public bool CrearEquipo(
           string nombre,
           string nombreCorto,
           string ciudad,
           string estadio,
           int capacidadEstadio,
           int anioFundacion,
           out string mensaje,
           out EquipoBE equipoCreado)
        {
            mensaje = "";
            equipoCreado = null;

            if (string.IsNullOrWhiteSpace(nombre) ||
                string.IsNullOrWhiteSpace(nombreCorto) ||
                capacidadEstadio <= 0 ||
                string.IsNullOrWhiteSpace(estadio) ||
                anioFundacion <= 0)
            {
                mensaje = "Todos los campos deben estar completos y válidos.";
                return false;
            }

            equipoCreado = new EquipoBE(
                Guid.NewGuid(),
                nombre,
                nombreCorto,
                ciudad,
                estadio,
                capacidadEstadio,
                anioFundacion
            );

            

            return true;
        }

        public void editarEquipo(EquipoBE equipoEditado)
        {

            
        }

        public List<EquipoBE> ObtenerTodos()
        {
            return null;
        }

        public EquipoBE ObtenerEquipoPorId(Guid id)
        {
            return null;
        }

        public string ObtenerNombrePorId(Guid id)
        {
            var equipos = ObtenerTodos();
            var equipo = equipos.FirstOrDefault(e => e.Id == id);
            return equipo?.Nombre ?? "Desconocido";
        }

        public void registrarEquiposEstadisticasVacio(List<EquipoBE> equipos)
        {
           
        }

        public void registrarPartidoEquipo(Guid equipoId, string resultado, int goles, int expulsiones)
        {
            
        }

        public List<EstadisticasCampeonatoBE> ObtenerEstadisticasCampeonato()
        {
            return null;
        }

        public List<EquipoBE> BuscarPorNombre(string nombreParcial)
        {
            return ObtenerTodos()
                .Where(a => a.Nombre.ToLower().Contains(nombreParcial.ToLower()))
            .ToList();
        }
    }
}

    
