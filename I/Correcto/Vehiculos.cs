using System;
using System.Collections.Generic;
using System.Text;

namespace I.Correcto
{
    class Coche2 : IVehiculoTerrestre, IVehiculo2
    {
        public void Corre()
        {
            throw new NotImplementedException();
        }

        public void TieneRuedas()
        {
            throw new NotImplementedException();
        }

        public void UsaCombustible()
        {
            throw new NotImplementedException();
        }
    }

    class Moto2 : IVehiculo2, IVehiculoTerrestre
    {
        public void Corre()
        {
            throw new NotImplementedException();
        }

        public void TieneRuedas()
        {
            throw new NotImplementedException();
        }

        public void UsaCombustible()
        {
            throw new NotImplementedException();
        }
    }

    class Avion : IVehiculoAereo , IVehiculo2
    {
        public void UsaCombustible()
        {
            throw new NotImplementedException();
        }

        public void vuela()
        {
            throw new NotImplementedException();
        }
    }

    class Barco : IVehiculoNautico, IVehiculo2
    {
        public void navega()
        {
            throw new NotImplementedException();
        }

        public void UsaCombustible()
        {
            throw new NotImplementedException();
        }
    }
}
