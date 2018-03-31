using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_Kingdom
{
    // Child class of Animal
    class Fox:Animal
    {

        // Functions which inherit from the Animal class
        // Note this is only an example of inheritance

        public string getFoxFood()
        {
            return ("I'm a fox and I like to eat " + eat);
        }
        public string getFoxLoc()
        {
            return ("I'm a fox and I live in " + location + ".");
        }
        public string getFoxType()
        {
            return ("Fox Type: " + animalType);
        }
        
    }
}
