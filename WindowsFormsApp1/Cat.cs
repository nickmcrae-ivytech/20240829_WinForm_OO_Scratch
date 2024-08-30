namespace WindowsFormsApp1
{
    public class Cat : IAnimal
    {
        public Cat(string name)
        {
            NumberOfLegs = 4;
            Sound = "meow";
            Name = name;
        }

        // props
        public string Sound { get; set; }
        public int NumberOfLegs { get; set; }
        public string Breed { get; set; }
        public string Name { get; set; }
        public bool IsDomesticated { get; set; }
        public string[] TricksLibrary { get; set; }

       

        public string Speak()
        {
            return Sound;
        }
    }
}
