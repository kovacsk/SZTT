﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactory.CarParts
{
    abstract class Chassis : IDiagnostics
    {
        public abstract void Diagnostics();
        public abstract void Make();
    }
}
