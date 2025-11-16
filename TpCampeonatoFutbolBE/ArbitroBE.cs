using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using TpCampeonatoFutbolBE.Abstracciones;

namespace TpCampeonatoFutbolBE
{
    public class ArbitroBE: PersonaBE
    {
		private Guid _id;

		public Guid Id
		{
			get { return _id; }
			set { _id = value; }
		}

        public ArbitroBE()
        {
            Id = Guid.NewGuid();
        }
        public ArbitroBE(Guid id, string nombre, string apellido, int edad, int dni, DateTime fechaNacimiento, string lugarNacimiento)
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
            Apellido = apellido;
            Edad = edad;
            Dni = dni;
            FechaNacimiento = fechaNacimiento;
            LugarNacimiento = lugarNacimiento;
        }
    }
}
