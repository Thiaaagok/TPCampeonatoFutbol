using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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


        public void RemoverEventosClick(Control control)
        {
            FieldInfo f1 = typeof(Control).GetField("EventClick", BindingFlags.Static | BindingFlags.NonPublic);
            if (f1 != null)
            {
                object obj = f1.GetValue(control);
                PropertyInfo pi = control.GetType().GetProperty("Events", BindingFlags.NonPublic | BindingFlags.Instance);
                EventHandlerList list = (EventHandlerList)pi.GetValue(control, null);
                list.RemoveHandler(obj, list[obj]);
            }
        }
    }
}
