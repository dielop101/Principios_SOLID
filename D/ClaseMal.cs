using System;
using System.Collections.Generic;
using System.Text;

namespace D
{
    class DDBBService
    {
        //...
        public void getDatos()
        {
            //implemntación de obtención de datos
        }

    }

    class AccesoADatos
    {

        private DDBBService databaseService;

        public AccesoADatos(DDBBService databaseService)
        {
            this.databaseService = databaseService;
        }

        void getDatos()
        {
            //obtiene los datos 
            databaseService.getDatos();

        }
    }
}
