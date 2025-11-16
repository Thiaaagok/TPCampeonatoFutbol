using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpCampeonatoFutbolBE
{
    public class EquipoBE
    {
        private Guid _Id;

        public Guid Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        private string _Nombre;

        public string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }

        private string _NombreCorto;

        public string NombreCorto
        {
            get { return _NombreCorto; }
            set { _NombreCorto = value; }
        }

        private string _Ciudad;

        public string Ciudad
        {
            get { return _Ciudad; }
            set { _Ciudad = value; }
        }

        private string _Estadio;

        public string Estadio
        {
            get { return _Estadio; }
            set { _Estadio = value; }
        }

        private int _CapacidadEstadio;

        public int CapacidadEstadio
        {
            get { return _CapacidadEstadio; }
            set { _CapacidadEstadio = value; }
        }

        private int _anioFundacion;
        public int AnioFundacion
        {
            get { return _anioFundacion; }
            set { _anioFundacion = value; }
        }

        private List<JugadorBE> _jugadores;
        public List<JugadorBE> Jugadores
        {
            get { return _jugadores; }
            set { _jugadores = value; }
        }

        public EquipoBE()
        {
            Id = Guid.NewGuid();
            Jugadores = new List<JugadorBE>();
        }

        public EquipoBE(Guid id, string nombre, string nombreCorto, string ciudad, string estadio, int capacidadEstadio, int anioFundacion)
        {
            if (id == null)
            {
                Id = Guid.NewGuid();
            }
            else
            {
                Id = id;
            }
            Nombre = nombre;
            NombreCorto = nombreCorto;
            Ciudad = ciudad;
            Estadio = estadio;
            CapacidadEstadio = capacidadEstadio;
            AnioFundacion = anioFundacion;
            Jugadores = new List<JugadorBE>();
        }


    }

}
    
