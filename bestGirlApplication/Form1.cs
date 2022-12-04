using System;
using System.Windows.Forms;

namespace bestGirlApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void calculate_Click(object sender, EventArgs e)
        {
            

            Console.WriteLine(niceFactor);
            Console.WriteLine(nagatoroFactor);
            Console.WriteLine(heartFactor);
            Console.WriteLine(killMeFactor);
            Console.WriteLine(hotFactor);
            Console.WriteLine(baddieFactor);
            Console.WriteLine(powerFactor);
            int BGTOTAL;


            int bestGirlScore = (niceFactor.SelectedIndex + nagatoroFactor.SelectedIndex + heartFactor.SelectedIndex + killMeFactor.SelectedIndex + hotFactor.SelectedIndex + 
                + powerFactor.SelectedIndex) / 6;

            if (baddieFactor.SelectedIndex < 1)
            {
                BGTOTAL = bestGirlScore + 1;
            }
            else
                BGTOTAL = bestGirlScore - 1;

            

            if (bestGirlScore >= 9)
            {
                resultLabel.Text = "Wow, " + nameTextBox.Text + " got a " + bestGirlScore;

                if (nameTextBox.Text == "Emilia")
                {
                    emiliaLabel.Text = "Thank you so much!";
                }

                if (nameTextBox.Text == "Chizuru")
                {
                    chizuruLabel.Text = "Pervert!";
                }
            }

            else if (niceFactor.SelectedIndex >= 7 && heartFactor.SelectedIndex >= 7 && killMeFactor.SelectedIndex >= 7 && hotFactor.SelectedIndex >= 7
               && powerFactor.SelectedIndex >= 7 && nagatoroFactor.SelectedIndex >= 7)
            {
                resultLabel.Text =  nameTextBox.Text + " got a " + bestGirlScore + ", not bad.";

                if (nameTextBox.Text == "Emilia")
                {
                    emiliaLabel.Text = "This is awkward...";
                }

                if (nameTextBox.Text == "Chizuru")
                {
                    chizuruLabel.Text = "Ugh...";
                }
            }

            else if (niceFactor.SelectedIndex >= 6 && heartFactor.SelectedIndex >= 6 && killMeFactor.SelectedIndex >= 6 && hotFactor.SelectedIndex >= 6
              &&  powerFactor.SelectedIndex >= 6 && nagatoroFactor.SelectedIndex >= 6)
            {
                resultLabel.Text = nameTextBox.Text + " got a " + bestGirlScore + ". Hm.";
                if (nameTextBox.Text == "Emilia")
                {
                    emiliaLabel.Text = "This is awkward...";
                }

                if (nameTextBox.Text == "Chizuru")
                {
                    chizuruLabel.Text = "Ugh...";
                }
            }

            else if (niceFactor.SelectedIndex >= 5 && heartFactor.SelectedIndex >= 5 && killMeFactor.SelectedIndex >= 5 && hotFactor.SelectedIndex >= 5
               &&  powerFactor.SelectedIndex >= 5 && nagatoroFactor.SelectedIndex >= 5)
            {
                resultLabel.Text =  nameTextBox.Text + " got a " + bestGirlScore + ". She mid.";

                if (nameTextBox.Text == "Emilia")
                {
                    emiliaLabel.Text = "This is awkward...";
                }

                if (nameTextBox.Text == "Chizuru")
                {
                    chizuruLabel.Text = "Ugh...";
                }
            }

            else if (niceFactor.SelectedIndex > -1 && heartFactor.SelectedIndex > -1 && nagatoroFactor.SelectedIndex > -1 && killMeFactor.SelectedIndex > -1 && hotFactor.SelectedIndex > -1 
                && powerFactor.SelectedIndex > -1)
            {
                resultLabel.Text = nameTextBox.Text + " got a " + bestGirlScore + ".\n That's a bit harsh \n but numbers don't lie I guess";

                if (nameTextBox.Text == "Emilia")
                {
                    emiliaLabel.Text = "That's mean!";
                }

                if (nameTextBox.Text == "Chizuru")
                {
                    chizuruLabel.Text = "Screw you!";
                }

                if (nameTextBox.Text == "Joseph")
                {
                    emiliaLabel.Text = "Hi Joseph";
                }
            }

            else
            {
                resultLabel.Text = "You haven't even filled\n everything out!";
            }

           


        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            niceFactor.SelectedItem = null;
            nagatoroFactor.SelectedItem = null;
            heartFactor.SelectedItem = null;
            killMeFactor.SelectedItem = null;
            hotFactor.SelectedItem = null;
            baddieFactor.SelectedItem = null;
            powerFactor.SelectedItem = null;
        }

        private void aboutButton_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }
    }
}
