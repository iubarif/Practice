using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstructFactory
{
    public class ToyotaCarFactory : ICarFactory
    {
        public ICar createCar(string carType)
        {

            switch (carType)
            {
                case "rav4":
                    return new Rav4();
                case "camry":
                    return new Camry();
                default:
                    throw new Exception("Invalid car Type (H)..");
            }
        }


    }
}
