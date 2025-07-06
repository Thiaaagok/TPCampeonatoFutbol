using System.ComponentModel;
using System.Reflection;
using System.Windows.Forms;

namespace TPCampeonatoFutbol.Modelos.Funciones
{
    public class Util
    {
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
