using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Snake : AnimalBase
    {
        public Snake(string name)
        {
            NumberOfLegs = 0;
            Sound = "sssssss";
            Name = name;
        }

        public override void LearnNewTrick(string newTrick)
        {
            if (TricksLibrary == null)
                TricksLibrary = new List<string>();

            TricksLibrary.Add("I'm a snake, I'm not gonna learn a trick...");
        }
    }
}
