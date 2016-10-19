using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstructFactory
{
    public class Camry : ICar
    {
        public void Drive()
        {
            Console.WriteLine("Driving Camry ...");
        }
    }
}
