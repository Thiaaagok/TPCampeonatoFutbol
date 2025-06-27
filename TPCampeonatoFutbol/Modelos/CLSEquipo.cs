using System;
using System.Collections.Generic;
using TPCampeonatoFutbol.Funciones;
using TPCampeonatoFutbol.Modelos;
using TPCampeonatoFutbol.Modelos.Funciones;
using TPCampeonatoFutbol.Modelos.Interfaces;

namespace TPCampeonatoFutbol
{
    public class CLSEquipo: IEquipo
    {

        private string rutaArchivos = "equipos.txt";

        private string _Id;

        public string Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        private string _Nombre;

        public string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }

        private string _NombreCorto;

        public string NombreCorto
        {
            get { return _NombreCorto; }
            set { _NombreCorto = value; }
        }

        private string _Ciudad;

        public string Ciudad
        {
            get { return _Ciudad; }
            set { _Ciudad = value; }
        }

        private string _Estadio;

        public string Estadio
        {
            get { return _Estadio; }
            set { _Estadio = value; }
        }

        private int _CapacidadEstadio;

        public int CapacidadEstadio
        {
            get { return _CapacidadEstadio; }
            set { _CapacidadEstadio = value; }
        }

        private int _anioFundacion;
        public int AnioFundacion
        {
            get { return _anioFundacion; }
            set { _anioFundacion = value; }
        }

        private List<CLSJugador> _jugadores;
        public List<CLSJugador> Jugadores
        {
            get { return _jugadores; }
            set { _jugadores = value; }
        }

        public CLSEquipo()
        {
            Util util = new Util();
            Id = util.GenerarId();
            Jugadores = new List<CLSJugador>();
        }

        public CLSEquipo(string id, string nombre, string nombreCorto, string ciudad, string estadio, int capacidadEstadio, int anioFundacion)
        {
            if(id == null)
            {
                Util util = new Util();
                Id = util.GenerarId();
            }
            else
            {
                Id = id;
            }
            Nombre = nombre;
            NombreCorto = nombreCorto;
            Ciudad = ciudad;
            Estadio = estadio;
            CapacidadEstadio = capacidadEstadio;
            AnioFundacion = anioFundacion;
            Jugadores = new List<CLSJugador>();
        }

        public void editarEquipo(CLSEquipo equipoEditado)
        {
            ManejoArchivos archivos = new ManejoArchivos();

            archivos.EditarRegistro<CLSEquipo>(
                rutaArchivos,
                e => e.Id == equipoEditado.Id,
                equipoEditado,
                equipo => $"{equipoEditado.Id},{equipo.Nombre},{equipo.NombreCorto},{equipo.Ciudad},{equipo.Estadio},{equipo.CapacidadEstadio},{equipo.AnioFundacion}",
                linea =>
                {
                    var partes = linea.Split(',');
                    return new CLSEquipo(
                        partes[0],
                        partes[1],
                        partes[2],
                        partes[3],
                        partes[4],
                        int.Parse(partes[5]),
                        int.Parse(partes[6])
                    );
                });
        }
    }

}