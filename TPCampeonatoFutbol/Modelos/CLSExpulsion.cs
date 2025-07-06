namespace TPCampeonatoFutbol
{
    public class CLSExpulsion
    {
        string Causa {  get; set; }

        private string _JugadorExpulsado;

        public string JugadorExpulsado
        {
            get { return _JugadorExpulsado; }
            set { _JugadorExpulsado = value; }
        }

    }
}