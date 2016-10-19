using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class Cat : IAnimal
    {
        public void eat()
        {
            Console.WriteLine("Cat is eating.");
        }
    }
}
