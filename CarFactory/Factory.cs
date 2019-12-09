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
            Random rnd = new Random(); // A hibakezelés miatt van rá szükség
          
            try
            {
                chassis.Diagnostics("Chassis",rnd.Next(1,100));
                body.Diagnostics("Body",rnd.Next(1,100));
                engine.Diagnostics("Engine",rnd.Next(1,100));
            }
            catch (CarPartException ex)
            {
                ProductionAlert.GetInstance().CarPartError(ex.ToString());
                
            }
                

            return new Car(chassis, body, engine);
            
            


        }
    }
}
