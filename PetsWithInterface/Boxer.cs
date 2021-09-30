using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BarkingDogs;

namespace PetsWithInterface
{
    class Boxer : IBark
    {

        
        public string Name { get; set; } = "Reggie";
        public string Color { get; set; } = "brown";
        public string BarkSound { get; set; } = "woof";

        public string Bark()
        {
            return BarkSound;

        }
    }
}
