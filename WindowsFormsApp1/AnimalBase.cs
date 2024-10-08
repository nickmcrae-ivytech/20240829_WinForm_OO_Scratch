﻿using System.Collections.Generic;
using System.Linq;

namespace WindowsFormsApp1
{
    public abstract class AnimalBase : IAnimal
    {
        // props
        public string AnimalId { get; set; }
        public string Sound { get; set; }
        public int NumberOfLegs { get; set; }
        public string Breed { get; set; }
        public string Name { get; set; }
        public bool IsDomesticated { get; set; }
        public List<string> TricksLibrary { get; set; }

        public virtual void LearnNewTrick(string newTrick)
        {
            TricksLibrary.Add(newTrick);
        }

        public virtual string Speak()
        {
            // return 
            return Sound;
        }
    }
}