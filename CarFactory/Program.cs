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
            
            
            Console.WriteLine("Milyen típus?");
            Console.WriteLine("[1] Roadster");
            Console.WriteLine("[2] Model S");
            Console.WriteLine("[3] Model Y");
            string tipus = Console.ReadLine();
            if (tipus == "1")
            {
                manufacturing = new RoadsterManufacturingPlant();
                factory.SetAssemblyPlant(manufacturing);
            }
            else if (tipus == "2")
            {
                manufacturing = new ModelSManufacturingPlant();
                factory.SetAssemblyPlant(manufacturing);
            }
            else if (tipus == "3")
            {
                manufacturing = new ModelYManufacturingPlant();
                factory.SetAssemblyPlant(manufacturing);
            }
            

            
            factory.InitAssemblyElements();

            List<Car> producedcars = new List<Car>();

            Console.WriteLine("mennyi auto?");
            string mennyiseg = Console.ReadLine();
            
            for (int i = 0; i < Convert.ToInt32(mennyiseg); i++)
            {
                factory.ProduceCarParts();
                
                
                var car = factory.AssembleCar();
                producedcars.Add(car);
                Console.WriteLine();
                Console.WriteLine(i+1 +". Autó elkészült");
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
