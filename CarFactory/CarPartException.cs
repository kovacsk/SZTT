using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactory
{
    class CarPartException : Exception
    {
        public void Exception()
        {
            ProductionAlert.GetInstance().CarPartError();
        }
    }
}
