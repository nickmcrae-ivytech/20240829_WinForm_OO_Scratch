using System.Collections.Generic;
using System.Linq;

namespace WindowsFormsApp1
{
    internal class Dog : Animal
    {

        public Dog(string name, string breed) 
        {
            NumberOfLegs = 4;
            Sound = "bark";
            Name = name;
            Breed = breed;
        }


        // methods or functions
        public override string Speak()
        {
            if (Breed != "Lab")
                return "YAP YAP YAP";

            return Sound;
        }
    }
}
