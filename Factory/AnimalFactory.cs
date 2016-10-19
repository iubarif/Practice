using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class AnimalFactory
    {
        public IAnimal createAnimal(string animalType)
        {
            switch (animalType) {
                case "dog":
                    return new Dog();
                case "cat":
                    return new Cat();
                default:
                    return null;
            }

        }
    }
}
