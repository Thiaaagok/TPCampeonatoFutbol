using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TpCampeonatoFutbolBE.Abstracciones;

namespace TpCampeonatoFutbolBE
{
    public class JugadorBE: PersonaBE
    {
        private Guid _Id;

        public Guid Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        private RolJugadorBE _Rol;

        public RolJugadorBE Rol
        {
            get { return _Rol; }
            set { _Rol = value; }
        }

        private Guid _EquipoId;

        public Guid EquipoId
        {
            get { return _EquipoId; }
            set { _EquipoId = value; }
        }

        private string _EquipoNombre;

        public string EquipoNombre
        {
            get { return _EquipoNombre; }
            set { _EquipoNombre = value; }
        }

        private Guid _RolId;

        public Guid RolId
        {
            get { return _RolId; }
            set { _RolId = value; }
        }

        private int _Goles;

        public int Goles
        {
            get { return _Goles; }
            set { _Goles = value; }
        }

        private int _TarjetasAmarillas;

        public int TarjetasAmarillas
        {
            get { return _TarjetasAmarillas; }
            set { _TarjetasAmarillas = value; }
        }

        private int _TarjetasRojas;

        public int TarjetasRojas
        {
            get { return _TarjetasRojas; }
            set { _TarjetasRojas = value; }
        }

        private Decimal _Precio;

        public Decimal Precio
        {
            get { return _Precio; }
            set { _Precio = value; }
        }


        public JugadorBE()
        {
            Id = Guid.NewGuid();
        }
        public JugadorBE(Guid id, string nombre, string apellido, int edad, int dni, DateTime fechaNacimiento, string lugarNacimiento, Guid equipoId, RolJugadorBE rol)
        {
            if (id == null)
            {
                Id = Guid.NewGuid();
            }
            else
            {
                Id = id;
            }
            EquipoId = equipoId;
            Rol = rol;
        }
    }

    public class RolJugadorBE
    {
        public string Descripcion { get; set; }

        public string Codigo { get; set; }

        public Guid Id { get; set; }

        public RolJugadorBE()
        {

        }

        public RolJugadorBE(string descripcion, string codigo)
        {
            Descripcion = descripcion;
            Codigo = codigo;
        }

        public static List<RolJugadorBE> ObtenerRoles()
        {
            return new List<RolJugadorBE>
            {
                new RolJugadorBE("Delantero", "Delantero"),
                new RolJugadorBE("Extremo Izquierdo", "ExtremoIzquierdo"),
                new RolJugadorBE("Extremo Derecho", "ExtremoDerecho"),
                new RolJugadorBE("Medio Centro Izquierdo", "MediocentroIzquierdo"),
                new RolJugadorBE("Mediocentro", "Mediocentro"),
                new RolJugadorBE("Medio Centro Derecho", "MediocentroDerecho"),
                new RolJugadorBE("Lateral Izquierdo", "LateralIzquierdo"),
                new RolJugadorBE("Defensa Central Izquierdo", "DefensacentralIzquierdo"),
                new RolJugadorBE("Defensa Central Derecho", "DefensacentralDerecho"),
                new RolJugadorBE("Lateral Derecho", "LateralDerecho"),
                new RolJugadorBE("Arquero", "Arquero"),
                new RolJugadorBE("Suplente 1", "Suplente1"),
                new RolJugadorBE("Suplente 2", "Suplente2"),
                new RolJugadorBE("Suplente 3", "Suplente3"),
                new RolJugadorBE("Suplente 4", "Suplente4"),
                new RolJugadorBE("Suplente 5", "Suplente5"),
            };
        }

    }
}
