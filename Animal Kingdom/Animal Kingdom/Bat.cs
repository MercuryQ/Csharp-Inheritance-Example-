using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_Kingdom
{
    // Child class of Animal
    class Bat :Animal
    {
        // Functions which inherit from the Animal class
        // Note this is only an example of inheritance
        public string getBatFood()
        {
            return ("I'm a bat and I like to eat " + eat);
        }
        public string getBatLoc()
        {
            return ("It's very dark in this cave and I live in " + location + ".");
        }
        public string getBatType()
        {
            return ("Bat Type: " + animalType);
        }
    }
}
