using NAudio.CoreAudioApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPCampeonatoFutbol.Modelos
{
    public class CLSArbitro: CLSPersona
    {
        private Guid _Id;

        public Guid Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        public CLSArbitro()
        {
            Id = Guid.NewGuid();
        }
        public CLSArbitro(Guid id, string nombre, string apellido, int edad, int dni, DateTime fechaNacimiento, string lugarNacimiento)
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

