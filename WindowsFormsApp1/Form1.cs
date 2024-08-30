using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public List<IAnimal> Animals { get; set; } 

        public Form1()
        {
            InitializeComponent();
            Animals = new List<IAnimal>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
            btnClose.BackColor = Color.Red;
            btnClose.Text = "Close";
            txtName.Focus();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            var breed = "Beagle";

            if (txtName.Text == "Tucker")
                breed = "Lab";
            Dog dog = new Dog(txtName.Text, breed);

            Animals.Add(dog);
        }

        private void btnAddCat_Click(object sender, EventArgs e)
        {
            Cat cat = new Cat(txtName.Text);
            Animals.Add(cat);
        }

        private void btnSpeak_Click(object sender, EventArgs e)
        {
            var sounds = new StringBuilder();
            foreach (var animal in Animals)
            {
                sounds.AppendLine(animal.Speak());
                animal.LearnNewTrick("");
            }



            lblOutput.Text = sounds.ToString();
        }
    }
}
