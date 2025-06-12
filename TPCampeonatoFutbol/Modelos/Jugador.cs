using System;
using System.Collections.Generic;

namespace TPCampeonatoFutbol
{
    public class Jugador: Persona
    {
        public Rol Rol { get; set; }

        public string Equipo { get; set; }

        public Jugador()
        {

        }
        public Jugador(string nombre, string apellido, int edad, int dni, DateTime fechaNacimiento, string lugarNacimiento, string equipo, Rol rol)
        {
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