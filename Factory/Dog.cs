using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class Dog : IAnimal
    {
        public void eat()
        {
            Console.WriteLine("Dog is eating.");
        }
    }
}
