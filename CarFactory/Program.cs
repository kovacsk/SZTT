using CarFactory.FactoryInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactory
{
    class Program
    {
        static public void Main(String[] args)
        {
            Factory factory = new Factory();
            ManufacturingPlant manufacturing;
            manufacturing = new ModelYAssemblyPlant();

            factory.SetAssemblyPlant(manufacturing);
            factory.InitAssemblyElements();

            List<Car> producedcars = new List<Car>();

            Console.WriteLine("mennyi auto?");
            string mennyiseg = Console.ReadLine();
            for (int i = 0; i < Convert.ToInt32(mennyiseg); i++)
            {
                factory.ProduceCarParts();
                var car = factory.AssembleCar();
                producedcars.Add(car);
            }
        }
    }
}
