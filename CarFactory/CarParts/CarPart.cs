using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactory.CarParts
{
    abstract class CarPart : IDiagnostics
    {

        public  void Diagnostics(string nev,int r)
        {
            if (r <= 10)
            {
                throw new CarPartException(nev);
            }
        }
        
        public abstract void Make();
    }
}
