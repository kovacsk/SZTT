using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactory.CarParts.Bodies
{
    class RoadsterBody : Body
    {
        public override void Make()
        {
            Console.WriteLine("RoadsterBody done.");
        }
    }
}
