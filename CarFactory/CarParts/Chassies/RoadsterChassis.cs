using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactory.CarParts.Chassies
{
    class RoadsterChassis : Chassis
    {
        public override void Make()
        {
            Console.WriteLine("RoadsterChassis done.");
        }
    }
}
