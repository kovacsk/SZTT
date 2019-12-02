using CarFactory.CarParts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactory
{
    class Car
    {
        private Chassis chassis;
        private Body body;
        private Engine engine;

        public Car(Chassis chassis, Body body, Engine engine)
        {
            this.chassis = chassis;
            this.body = body;
            this.engine = engine;
        }
    }
}
