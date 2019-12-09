using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactory
{
    class CarPartException : Exception
    {
        public CarPartException(string message) : base(message)
        {
        }
    }
}
