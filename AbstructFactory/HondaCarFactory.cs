using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstructFactory
{
    public class HondaCarFactory : ICarFactory
    {
        public ICar createCar(string carType)
        {
            switch (carType) {
                case "civic":
                    return new Civic();
                case "crv":
                    return new CRV();
                default:
                    throw new Exception("Invalid car Type (H)..");
            }
        }
    }
}
