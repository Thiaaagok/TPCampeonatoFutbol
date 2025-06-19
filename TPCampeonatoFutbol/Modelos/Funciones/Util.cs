using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPCampeonatoFutbol.Modelos.Funciones
{
    public class Util
    {

        public string GenerarId()
        {
            string id = "";
            string caracteres = "qwertyuiopasdfghjklzxcvbnm1234567890";
            Random ran = new Random();
            for (int i = 0; i < 20; i++)
            {
                int indice = ran.Next(caracteres.Length);
                char caracter = caracteres[indice];
                id += caracter;
            }
            return id;
        }
    }
}
