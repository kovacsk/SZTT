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
        public void InitAssemblyElements()
        {
            chassis = assemblyPlant.CreateChassis();
            body = assemblyPlant.CreateBody();
            engine = assemblyPlant.CreateEngine();
        }

        public void ProduceCarParts()
        {
            chassis.Make();
            body.Make();
            engine.Make();
        }

        public Car AssembleCar(Chassis chassis, Body body, Engine engine)
        {
            return new Car(chassis, body, engine);
        }
    }
}
