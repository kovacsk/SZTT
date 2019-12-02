using CarFactory.CarParts;
using CarFactory.CarParts.Chassies;
using CarFactory.CarParts.Engines;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactory.AssemblyPlant
{
    class ModelSAssemblyPlant
    {
        public Chassis CreateChassis() { return new ModelSChassis(); }
        public Body CreateBody() { return new ModelSBody(); }
        public Engine CreateEngine() { return new ModelSEngine(); }

    }
}
