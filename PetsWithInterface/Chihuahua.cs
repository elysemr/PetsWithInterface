using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BarkingDogs;

namespace PetsWithInterface
{
    class Chihuahua : IBark
    {

        public string Name { get; set; } = "Pedro";
        public string Color { get; set; } = "tan";
        public string BarkSound { get; set; } = "yap";

        public string Bark()
        {
            return BarkSound;

        }

        public string Walk() //not part of interface
        {
            return "Walking the dog.";
        }
    }

}

