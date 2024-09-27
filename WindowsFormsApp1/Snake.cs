using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Snake : Reptile
    {
        public Snake(string name)
            : base(true)
        {
            NumberOfLegs = 0;
            Sound = "sssssss";
            Name = name;
        }

        public override void LearnNewTrick(string newTrick)
        {
            if (TricksLibrary == null)
                TricksLibrary = new List<string>();

            newTrick = "I'm a snake, I'm not gonna learn a trick...";

            base.LearnNewTrick(newTrick);
            ////TricksLibrary.Add("I'm a snake, I'm not gonna learn a trick...");
        }
    }
}
