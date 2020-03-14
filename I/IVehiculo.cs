using System;
using System.Collections.Generic;
using System.Text;

namespace I
{
    interface IVehiculo
    {
        void Corre();
        void UsaCombustible();
        void TieneRuedas();

        //Avion aparte de los metodos anteriores necesitaria un metodo vuela
        //void vuela();
    }
}
