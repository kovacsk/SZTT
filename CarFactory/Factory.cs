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

        private ManufacturingPlant manufacturingPlant;

        public void SetAssemblyPlant(ManufacturingPlant ap)
        {
            manufacturingPlant = ap;
        }
        public void InitAssemblyElements()
        {
            chassis = manufacturingPlant.CreateChassis();
            body = manufacturingPlant.CreateBody();
            engine = manufacturingPlant.CreateEngine();
        }

        public void ProduceCarPartsWithFailedChassis()
        {
            chassis.Make();
            chassis.errorflag = true;
            body.Make();
            engine.Make();
        }
        public void ProduceCarParts()
        {
            chassis.Make();
            body.Make();
            engine.Make();
        }

        public Car AssembleCar()
        {
          
                chassis.Diagnostics();
                body.Diagnostics();
                engine.Diagnostics();

            
            


            return new Car(chassis, body, engine);
        }
    }
}
