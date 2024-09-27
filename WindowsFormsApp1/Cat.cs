using System.Collections.Generic;

namespace WindowsFormsApp1
{
    internal class Cat : Animal
    {
        public Cat(string name)
        {
            NumberOfLegs = 4;
            Sound = "meow";
            Name = name;
        }
    }
}
