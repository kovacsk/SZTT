using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactory.CarParts.Chassies
{
    class ModelSChassis : Chassis
    {
        public override void Make()
        {
            Console.WriteLine("ModelSChassis done.");
        }
    }
}
