using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstructFactory
{
    public class Civic : ICar
    {
        public void Drive()
        {
            Console.WriteLine("Driving Civic ...");
        }
    }
}
