using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPCampeonatoFutbol
{
    public abstract class CLSPersona
    {

        private int _Edad;

        public int Edad
        {
            get { return _Edad; }
            set { _Edad = value; }
        }

        private string _Nombre;

        public string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }

        private string _Apellido;

        public string Apellido
        {
            get { return _Apellido; }
            set { _Apellido = value; }
        }


        private int _Dni;

        public int Dni
        {
            get { return _Dni; }
            set { _Dni = value; }
        }

        private DateTime _FechaNacimiento;
        public DateTime FechaNacimiento
        {
            get { return _FechaNacimiento; }
            set { _FechaNacimiento = value; }
        }

        private string _LugarNacimieno;
        public string LugarNacimiento
        {
            get { return _LugarNacimieno; }
            set { _LugarNacimieno = value; }
        }

    }
}
