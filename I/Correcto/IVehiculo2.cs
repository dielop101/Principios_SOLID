using System;
using System.Collections.Generic;
using System.Text;

namespace I
{

    interface IVehiculo2
    {
        void UsaCombustible();
        
    }

    interface IVehiculoTerrestre
    {
        void Corre();
        void TieneRuedas();
        
    }

    interface IVehiculoAereo
    {
        void vuela();
    }

    interface IVehiculoNautico
    {
        void navega();
    }
}
