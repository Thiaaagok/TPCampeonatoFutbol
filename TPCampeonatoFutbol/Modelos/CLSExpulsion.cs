namespace TPCampeonatoFutbol
{
    internal class CLSExpulsion
    {
        string Causa {  get; set; }

        private CLSJugador _JugadorExpulsado;

        public CLSJugador JugadorExpulsado
        {
            get { return _JugadorExpulsado; }
            set { _JugadorExpulsado = value; }
        }

    }
}