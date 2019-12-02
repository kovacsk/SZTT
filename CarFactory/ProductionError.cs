using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactory
{
    class ProductionError
    {
        private static ProductionError instance;

        public static ProductionError GetInstance()
        {
            if (instance == null)
            {
                instance = new ProductionError();
            }
            return instance;
        }

        protected ProductionError() { }

        public void CarPartError()
        {
            Console.WriteLine("CarPartError");
        }

    }
}
