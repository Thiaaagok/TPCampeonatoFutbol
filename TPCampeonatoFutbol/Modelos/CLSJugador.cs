using System;
using System.Collections.Generic;
using TPCampeonatoFutbol.Modelos.Funciones;

namespace TPCampeonatoFutbol
{
    public class CLSJugador: CLSPersona
    {
        private string _Id;

        public string Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        private Rol _Rol;

        public Rol Rol
        {
            get { return _Rol; }
            set { _Rol = value; }
        }

        private string _Equipo;

        public string Equipo
        {
            get { return _Equipo; }
            set { _Equipo = value; }
        }

        public CLSJugador()
        {
            Util util = new Util();
            Id = util.GenerarId();
        }
        public CLSJugador(string id,string nombre, string apellido, int edad, int dni, DateTime fechaNacimiento, string lugarNacimiento, string equipo, Rol rol)
        {
            if (id == null)
            {
                Util util = new Util();
                Id = util.GenerarId();
            }
            else
            {
                Id = id;
            }
            Nombre = nombre;
            Apellido = apellido;
            Edad = edad;
            Dni = dni;
            FechaNacimiento = fechaNacimiento;
            LugarNacimiento = lugarNacimiento;
            Equipo = equipo;
            Rol = rol;
        }
    }

    public class Rol
    {
        public string Descripcion {  get; set; }

        public string Codigo { get; set; }

        public Rol()
        {
            
        }

        public Rol(string descripcion, string codigo)
        {
           Descripcion = descripcion;
           Codigo = codigo;
        }

        public static List<Rol> ObtenerRoles()
        {
            return new List<Rol>
            {
                new Rol("Delantero", "Delantero"),
                new Rol("Extremo Izquierdo", "ExtremoIzquierdo"),
                new Rol("Extremo Derecho", "ExtremoDerecho"),
                new Rol("Medio Centro Izquierdo", "MediocentroIzquierdo"),
                new Rol("Mediocentro", "Mediocentro"),
                new Rol("Medio Centro Derecho", "MediocentroDerecho"),
                new Rol("Lateral Izquierdo", "LateralIzquierdo"),
                new Rol("Defensa Central Izquierdo", "DefensacentralIzquierdo"),
                new Rol("Defensa Central Derecho", "DefensacentralDerecho"),
                new Rol("Lateral Derecho", "LateralDerecho"),
                new Rol("Arquero", "Arquero"),
                new Rol("Suplente 1", "Suplente1"),
                new Rol("Suplente 2", "Suplente2"),
                new Rol("Suplente 3", "Suplente3"),
                new Rol("Suplente 4", "Suplente4"),
                new Rol("Suplente 5", "Suplente5"),
            };
        }

    }


}