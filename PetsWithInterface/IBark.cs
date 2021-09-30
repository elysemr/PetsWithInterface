using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarkingDogs
{
    interface IBark
    {
        //interfaces focus mostly on methods that are in common in mostly disparate classes
        //put definition of what bark looks like
        string Bark(); //now we have a type that says any class that implements this interface must have a method that looks like this
                       //doesn't return anything and takes no parameters, what you do with it doesn't matter

        string Name { get; set; }
        string Color { get; set; }
        string BarkSound { get; set; } //now can call any of these props when iterating through collection
    }
}
