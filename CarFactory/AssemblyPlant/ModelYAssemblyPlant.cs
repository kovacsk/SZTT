using CarFactory.CarParts;
using CarFactory.CarParts.Bodies;
using CarFactory.CarParts.Chassies;
using CarFactory.CarParts.Engines;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactory.AssemblyPlant
{
    class ModelYAssemblyPlant
    {
        public Chassis CreateChassis() { return new ModelYChassis(); }
        public Body CreateBody() { return new ModelYBody(); }
        public Engine CreateEngine() { return new ModelYEngine(); }
    }
}
