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

        private CLSRol _Rol;

        public CLSRol Rol
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
        public CLSJugador(string id,string nombre, string apellido, int edad, int dni, DateTime fechaNacimiento, string lugarNacimiento, string equipo, CLSRol rol)
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

    public class CLSRol
    {
        public string Descripcion {  get; set; }

        public string Codigo { get; set; }

        public CLSRol()
        {
            
        }

        public CLSRol(string descripcion, string codigo)
        {
           Descripcion = descripcion;
           Codigo = codigo;
        }

        public static List<CLSRol> ObtenerRoles()
        {
            return new List<CLSRol>
            {
                new CLSRol("Delantero", "Delantero"),
                new CLSRol("Extremo Izquierdo", "ExtremoIzquierdo"),
                new CLSRol("Extremo Derecho", "ExtremoDerecho"),
                new CLSRol("Medio Centro Izquierdo", "MediocentroIzquierdo"),
                new CLSRol("Mediocentro", "Mediocentro"),
                new CLSRol("Medio Centro Derecho", "MediocentroDerecho"),
                new CLSRol("Lateral Izquierdo", "LateralIzquierdo"),
                new CLSRol("Defensa Central Izquierdo", "DefensacentralIzquierdo"),
                new CLSRol("Defensa Central Derecho", "DefensacentralDerecho"),
                new CLSRol("Lateral Derecho", "LateralDerecho"),
                new CLSRol("Arquero", "Arquero"),
                new CLSRol("Suplente 1", "Suplente1"),
                new CLSRol("Suplente 2", "Suplente2"),
                new CLSRol("Suplente 3", "Suplente3"),
                new CLSRol("Suplente 4", "Suplente4"),
                new CLSRol("Suplente 5", "Suplente5"),
            };
        }

    }


}