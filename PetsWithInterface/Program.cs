using System;
using System.Collections.Generic;
using BarkingDogs;

namespace PetsWithInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            var dogs = new List <IBark>() //can't put class between <> bc all different classes, nothing in common, have to use interface
            
            { 
                new Collie(), new Boxer(), new Chihuahua()
            };
            
            foreach(var dog in dogs) {
                Console.WriteLine($"The dog {dog.Name} barks {dog.Bark()}."); //can't even call name, can only call bark because that's the only thing in the interface
                var chi = dog as Chihuahua;  //as allows system to try turning dog into class chihuahua, if dog in loop isn't chihuahua will put null   
                    if(chi != null)  //when it is a chihuahua it converts that instance to a chihuahua and call a non-interface method           

                {
                    Console.WriteLine($"Guess what I'm doing with the chihuahua: {chi.Walk()}");
                }
                        
                        } //var chi disappears outside of this because it's in the foreach loop, disappears and is re-created for each iteration
        }
    }
}
