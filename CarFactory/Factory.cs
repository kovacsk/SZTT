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

        
        public void ProduceCarParts()
        {
            chassis.Make();
            body.Make();
            engine.Make();
        }

        public Car AssembleCar()
        {
            try
            {
                chassis.Diagnostics();
                body.Diagnostics();
                engine.Diagnostics();
            }
            catch (CarPartException ex)
            {
                ProductionAlert.GetInstance().CarPartError(ex.ToString());
                
            }
                

            return new Car(chassis, body, engine);
            
            


        }
    }
}
