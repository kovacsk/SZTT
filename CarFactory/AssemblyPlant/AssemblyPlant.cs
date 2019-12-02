using CarFactory.CarParts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactory.FactoryInterface
{
    interface AssemblyPlant
    {
        Chassis CreateChassis();
        Body CraeteBody();
        Engine CreateEngine();
    }
}
