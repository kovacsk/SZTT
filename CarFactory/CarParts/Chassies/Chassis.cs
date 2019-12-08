using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactory.CarParts
{
    abstract class Chassis : IDiagnostics
    {
        public bool errorflag = false;
        public void Diagnostics()
        {
            if (errorflag)
            {
                throw new CarPartException();
            }
        }
        public abstract void Make();

        public void SetErrorFlagTrue()
        {
            errorflag = true;
        }
    }
}
