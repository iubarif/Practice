using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            AnimalFactory af = new AnimalFactory();
            IAnimal a = af.createAnimal("fox");
            a.eat();

            Console.ReadLine();
        }
    }
}
