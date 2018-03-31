using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_Kingdom
{
    // Parent Class Animal
    public class Animal
    {
        // Some attributes that animals have declared as variables
        protected string location;
        protected int age;
        protected string eat;
        protected string animalType;

        // Constructors
        public void setLocation(string place)
        {
            location = place;
        }
        public void setAge(int aYears)
        {
            age = aYears;
        }
        public void setFood(string aEat)
        {
            eat = aEat;
        }
        public void setAnimal(string type)
        {
            animalType = type;
        }

        // Age function can be accessed through this class
        public int getAge()
        {
            return age;
        }

    }
}

