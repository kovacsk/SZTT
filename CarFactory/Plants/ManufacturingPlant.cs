using CarFactory.CarParts;
using CarFactory.CarParts.Bodies;
using CarFactory.CarParts.Chassies;
using CarFactory.CarParts.Engines;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactory.FactoryInterface
{
    interface ManufacturingPlant
    {
        Chassis CreateChassis();
        Body CreateBody();
        Engine CreateEngine();
    }
    class ModelYManufacturingPlant : ManufacturingPlant
    {
        public Chassis CreateChassis() { return new ModelYChassis(); }
        public Body CreateBody() { return new ModelYBody(); }
        public Engine CreateEngine() { return new ModelYEngine(); }


    }
    class ModelSManufacturingPlant : ManufacturingPlant
    {
        public Chassis CreateChassis() { return new ModelSChassis(); }
        public Body CreateBody() { return new ModelSBody(); }
        public Engine CreateEngine() { return new ModelSEngine(); }

    }
    class RoadsterManufacturingPlant : ManufacturingPlant
    {
        public Chassis CreateChassis() { return new RoadsterChassis(); }
        public Body CreateBody() { return new RoadsterBody(); }
        public Engine CreateEngine() { return new RoadsterEngine(); }

    }
}
