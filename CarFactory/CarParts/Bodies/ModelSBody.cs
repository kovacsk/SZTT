using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactory.CarParts
{
    class ModelSBody : Body
    {
        public override void Diagnostics()
        {
            throw new NotImplementedException();
        }

        public override void Make()
        {
            Console.WriteLine("ModelSBody done.");
        }
    }
}
