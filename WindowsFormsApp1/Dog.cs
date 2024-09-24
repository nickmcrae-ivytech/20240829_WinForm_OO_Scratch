using System.Collections.Generic;
using System.Linq;

namespace WindowsFormsApp1
{
    public class Dog : IAnimal
    {

        public Dog(string name, string breed) 
        {
            NumberOfLegs = 4;
            Sound = "bark";
            Name = name;
            Breed = breed;
        }

        // properties and/or attributes
        public string Sound { get; set; }
        public int NumberOfLegs { get; set; }
        public string Breed { get; set; }
        public string Name { get; set; }
        public bool IsDomesticated { get; set; }    
        public List<string> TricksLibrary { get; set; }

        public void LearnNewTrick(string newTrick)
        {
            TricksLibrary.Add(newTrick);
        }


        // methods or functions
        public string Speak()
        {
            if (Breed != "Lab")
                return "YAP YAP YAP";

            return Sound;
        }
    }
}
