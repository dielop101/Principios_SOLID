using System;
using System.Collections.Generic;
using System.Text;

namespace D.bien
{
    interface Conexion
    {
        void getDatos();
        void setDatos();
    }

    class AccesoADatos
    {

        private Conexion conexion;

        public AccesoADatos(Conexion conexion)
        {
            this.conexion = conexion;
        }

        void getDatos()
        {
            conexion.getDatos();
        }
    }
}
