using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstructFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            ICarFactory factory = FactoryProducer.getCarFactory("honda");
            ICar car =  factory.createCar("crv");
            car.Drive();


            Console.ReadLine();
        }
    }
}
