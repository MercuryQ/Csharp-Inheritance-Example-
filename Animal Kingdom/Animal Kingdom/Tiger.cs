using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_Kingdom
{
    // Child class of Animal
    class Tiger :Animal
    {
        // Functions which inherit from the Animal class
        // Note this is only an example of inheritance
        public string getTigerFood()
        {
            return ("I'm a tiger and I like to eat " + eat);
        }
        public string getTigerLoc()
        {
            return ("I'm a tiger and I live in " + location + ".");
        }
        public string getTigerType()
        {
            return ("Tiger Type: " + animalType);
        }

    }
}
