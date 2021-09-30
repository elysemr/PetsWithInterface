using BarkingDogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetsWithInterface
{
    class Collie : IBark //implement interface same way as inherit
    {
        public string Name { get; set; } = "Rapunzel";
        public string Color { get; set; } = "white and golden";
        public string BarkSound { get; set; } = "bark";

        public string Bark()
        {
            return BarkSound;
        }

    }
}
