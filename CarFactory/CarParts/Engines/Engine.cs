using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactory.CarParts
{
    abstract class Engine : IDiagnostics
    {
        public abstract void Diagnostics();
        public abstract void Make();
    }
}
