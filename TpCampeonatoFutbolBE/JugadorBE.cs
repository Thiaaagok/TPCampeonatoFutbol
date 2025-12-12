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

        private RolBE _Rol;

        public RolBE Rol
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
        public JugadorBE(Guid id, string nombre, string apellido, int edad, int dni, DateTime fechaNacimiento, string lugarNacimiento, Guid equipoId, RolBE rol)
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

    public class RolBE
    {
        public string Descripcion { get; set; }

        public string Codigo { get; set; }

        public Guid Id { get; set; }

        public RolBE()
        {

        }

        public RolBE(string descripcion, string codigo)
        {
            Descripcion = descripcion;
            Codigo = codigo;
        }

        public static List<RolBE> ObtenerRoles()
        {
            return new List<RolBE>
            {
                new RolBE("Delantero", "Delantero"),
                new RolBE("Extremo Izquierdo", "ExtremoIzquierdo"),
                new RolBE("Extremo Derecho", "ExtremoDerecho"),
                new RolBE("Medio Centro Izquierdo", "MediocentroIzquierdo"),
                new RolBE("Mediocentro", "Mediocentro"),
                new RolBE("Medio Centro Derecho", "MediocentroDerecho"),
                new RolBE("Lateral Izquierdo", "LateralIzquierdo"),
                new RolBE("Defensa Central Izquierdo", "DefensacentralIzquierdo"),
                new RolBE("Defensa Central Derecho", "DefensacentralDerecho"),
                new RolBE("Lateral Derecho", "LateralDerecho"),
                new RolBE("Arquero", "Arquero"),
                new RolBE("Suplente 1", "Suplente1"),
                new RolBE("Suplente 2", "Suplente2"),
                new RolBE("Suplente 3", "Suplente3"),
                new RolBE("Suplente 4", "Suplente4"),
                new RolBE("Suplente 5", "Suplente5"),
            };
        }

    }
}
