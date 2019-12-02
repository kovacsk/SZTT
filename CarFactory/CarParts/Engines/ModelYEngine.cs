using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactory.CarParts.Engines
{
    class ModelYEngine : Engine
    {
        public override void Diagnostics()
        {
            ProductionError.GetInstance().CarPartError();
        }

        public override void Make()
        {
            Console.WriteLine("ModelYEngine done.");
        }
    }
}
