using System;
using System.Collections.Generic;
using TPCampeonatoFutbol.Modelos;
using TPCampeonatoFutbol.Modelos.Funciones;
using TPCampeonatoFutbol.Modelos.Interfaces;

namespace TPCampeonatoFutbol
{
    public class CLSCampeonato
    {

        public List<CLSFecha> GenerarCampeonato(List<CLSEquipo> equipos)
        {
            GeneradorDeFixture gen = new GeneradorDeFixture();
            return gen.Generar(equipos);
        }
    }

}