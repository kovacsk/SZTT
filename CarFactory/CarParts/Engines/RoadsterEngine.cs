﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactory.CarParts.Engines
{
    class RoadsterEngine : Engine
    {
        public override void Make()
        {
            Console.WriteLine("RoadsterEngine done.");
        }
    }
}