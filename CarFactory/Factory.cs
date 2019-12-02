using CarFactory.CarParts;
using CarFactory.FactoryInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactory
{
    class Factory
    {
        private Car car;
        private Chassis chassis;
        private Body body;
        private Engine engine;

        private AssemblyPlant assemblyPlant;

        public void SetAssemblyPlant(AssemblyPlant ap)
        {
            assemblyPlant = ap;
        }

    }
}
