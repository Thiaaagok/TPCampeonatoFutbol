namespace TPCampeonatoFutbol
{
    internal class Jugador
    {
        Persona datosPersonales {  get; set; }
        Rol rol { get; set; }
    }

    internal class Rol
    {
        string descripcion {  get; set; }
    }
}