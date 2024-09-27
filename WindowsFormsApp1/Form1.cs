using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public List<IAnimal> Animals { get; set; }
        public IAnimal SelectedAnimal { get; set; }


        private enum AnimalsEnum
        {
            Dog = 1,
            Cat = 2,
            Snake = 3,
        }

        public Form1()
        {
            InitializeComponent();
            Animals = new List<IAnimal>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
            txtName.Focus();
            ddlAnimalTypes.DataSource = Enum.GetValues(typeof(AnimalsEnum));

            lstAnimals.View = View.Details;
            lstAnimals.FullRowSelect = true;
            lstAnimals.GridLines = true;

            lstAnimals.Columns.Add("Name", 75);
            lstAnimals.Columns.Add("Type", 50);

            // Add event to handle item selection
            lstAnimals.ItemSelectionChanged += lstAnimals_ItemSelectionChanged;

            lblAnimalName.Text = string.Empty;
            lblDetails.Text = string.Empty;

        }



        private void btnSpeak_Click(object sender, EventArgs e)
        {
            if (SelectedAnimal == null)
                return;

            lblSpeak.Text = SelectedAnimal.Speak();
        }

        private void lstAnimals_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (!e.IsSelected)
                return;

            if (e.Item != null && e.Item.SubItems.Count > 0)
            {
                var animal = Animals.FirstOrDefault(_ => _.Name == e.Item.SubItems[0].Text && _.GetType().Name == e.Item.SubItems[1].Text);
                loadAnimalDets(animal);
            }
        }

        private void loadAnimalDets(IAnimal animal)
        {
            SelectedAnimal = animal;
            lblAnimalName.Text = animal.Name;

            

            var sb = new StringBuilder();
            sb.AppendLine($"Animal Id: {animal.AnimalId}");
            sb.AppendLine($"Type: {animal.GetType().Name}");
            sb.AppendLine($"Sound: {animal.Sound}");
            sb.AppendLine($"Number of Legs: {animal.NumberOfLegs}");
            sb.AppendLine($"Breed: {animal.Breed}");
            sb.AppendLine($"Is Domesticated: {animal.IsDomesticated}");
            if (animal.TricksLibrary != null)
                sb.AppendLine($"Tricks: {string.Join(", ", animal.TricksLibrary)}");

            lblDetails.Text = sb.ToString();
        }

        private void btnAddAnimal_Click(object sender, EventArgs e)
        {
            if (txtName.Text.IsNotNil())
                return;

            var snake = new Snake("Jake");
            snake.Name = txtName.Text;
            //snake.AnimalId = txtName.Text;
            //snake.GenerateAnimalId();
            snake.Length = txtName.Text.Length;
            snake.LearnNewTrick("");

            IAnimal newAnimal;
            switch (ddlAnimalTypes.SelectedValue)
            {
                case AnimalsEnum.Dog:
                    newAnimal = new Dog(txtName.Text, "Lab");
                    break;
                case AnimalsEnum.Cat:
                    newAnimal = new Cat(txtName.Text);
                    break;
                case AnimalsEnum.Snake:
                    newAnimal = new Snake(txtName.Text);
                    break;
                default:
                    return;
            }

            // add the animal to the list in memory 
            Animals.Add(newAnimal);

            // add the animal to the list on the form
            lstAnimals.Items.Add(new ListViewItem(new[] { newAnimal.Name, newAnimal.GetType().Name }));

            // set teh selected animal and load it's dets
            SelectedAnimal = newAnimal;
            loadAnimalDets(newAnimal);

            // clear the form
            txtName.Text = string.Empty;
        }

        private void btnNewTrick_Click(object sender, EventArgs e)
        {
            if (SelectedAnimal == null)
                return;

            if (SelectedAnimal.TricksLibrary == null)
                SelectedAnimal.TricksLibrary = new List<string>();

            if (!SelectedAnimal.TricksLibrary.Contains("Sit"))
                SelectedAnimal.LearnNewTrick("Sit");
            else if (!SelectedAnimal.TricksLibrary.Contains("Down"))
                SelectedAnimal.LearnNewTrick("Down");
            else if (!SelectedAnimal.TricksLibrary.Contains("Stay"))
                SelectedAnimal.LearnNewTrick("Stay");
            else if (!SelectedAnimal.TricksLibrary.Contains("Write Code"))
                SelectedAnimal.LearnNewTrick("Write Code");

            loadAnimalDets(SelectedAnimal);
        }

    }
}
