using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactory
{
    class ProductionAlert
    {
        private static ProductionAlert instance;

        public static ProductionAlert GetInstance()
        {
            if (instance == null)
            {
                instance = new ProductionAlert();
            }
            return instance;
        }

        private ProductionAlert() { }

        public void CarPartError(string error)
        {
            Console.WriteLine(error + "CarPartError");
        }

    }
}
