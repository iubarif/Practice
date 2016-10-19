using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstructFactory
{
    public class FactoryProducer
    {
        public static ICarFactory getCarFactory(string factoryType)
        {
            switch (factoryType)
            {
                case "honda":
                    return new HondaCarFactory();
                case "toyota":
                    return new ToyotaCarFactory();
                default:
                    throw new Exception("Invalid factory Type (H)..");
            }
        }
    }
}
 