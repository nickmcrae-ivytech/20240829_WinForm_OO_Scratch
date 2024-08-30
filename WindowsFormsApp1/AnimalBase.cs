using System.Linq;

namespace WindowsFormsApp1
{
    public class AnimalBase : IAnimal
    {

        public void LearnNewTrick(string newTrick)
        {
            TricksLibrary.Append(newTrick);
        }
    }
}