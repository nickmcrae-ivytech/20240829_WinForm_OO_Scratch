using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Animal : AnimalBase
    {
        public Animal() 
        {
            AnimalId = GenerateAnimalId();
        }

        public Animal(bool useShortId)
        {
            var newId = GenerateAnimalId();
            if (useShortId) 
                newId = newId.Substring(0, 5);
            AnimalId = newId;
        }

        protected string GenerateAnimalId()
        {
            return Guid.NewGuid().ToString();
        }

        
    }

    internal static class ExtensionMethods
    {

        internal static void GenerateNewAnimalId(this Animal animal)
        {
            animal.AnimalId = Guid.NewGuid().ToString();
        }
    }
}
