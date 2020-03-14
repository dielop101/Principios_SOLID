using System;
using System.Collections.Generic;
using System.Text;

namespace L
{
    abstract class Audi
    {
        public virtual int speed()
        {
            return 200;  //kilometros x hora
        } 
    }

    class Audi2018 : Audi
    {
        public override int speed()
        {
            return 215;  //Kilometros x hora
        }
    }

    class Audi2019 : Audi
    {
        public override int speed()
        {
            return 250;  //kilometros x hora
        }
    }
}
