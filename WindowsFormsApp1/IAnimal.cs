using System.Collections.Generic;
using System.Linq;

namespace WindowsFormsApp1
{
    public interface IAnimal
    {
        // properties and/or attributes
        string Sound { get; set; }
        int NumberOfLegs { get; set; }
        string Breed { get; set; }
        string Name { get; set; }
        bool IsDomesticated { get; set; }
        List<string> TricksLibrary { get; set; }

        // methods or functions
        string Speak();
        void LearnNewTrick(string newTrick);
    }
}
