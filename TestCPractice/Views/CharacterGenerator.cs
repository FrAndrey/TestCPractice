using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace TestCPractice.Views
{
    public partial class CharacterGenerator : TestCPractice.Views.MasterForm
    {
        List<string> FirstNameList = new List<string>();
        List<string> LastNameList = new List<string>();

        public CharacterGenerator()
        {
            InitializeComponent();


        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            if (MainTabControl.SelectedIndex < MainTabControl.TabPages.Count -1)
            {
                MainTabControl.SelectedIndex++;
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            if(MainTabControl.SelectedIndex != 0)
            {
                MainTabControl.SelectedIndex--;
            }
            
        }
        private void LoadNames()
        {  
            using (StreamReader inputStream = new StreamReader(
         File.Open("firstNames.txt", FileMode.Open)))
            {
                string line;
                int counter = 0;
                while ((line = inputStream.ReadLine()) != null)
                {
                    FirstNameList.Add(line);
                    counter++;
                }
                inputStream.Close();
                inputStream.Dispose();        
            }

            using (StreamReader inputLStream = new StreamReader(
     File.Open("lastNames.txt", FileMode.Open)))
            {
                string line;
                int counter = 0;
                while ((line = inputLStream.ReadLine()) != null)
                {
                    LastNameList.Add(line);
                    counter++;
                }
                inputLStream.Close();
                inputLStream.Dispose();
            }
        }


        private void GenerateNames(object sender, EventArgs e)
        {
            LoadNames();
            Random randFirst = new Random();
            Random randLast = new Random();
     
            int randIndexForFirstName = randFirst.Next(0, FirstNameList.Count - 1);
            int randIndexForLastName = randLast.Next(0, LastNameList.Count - 1);

            FirstNameDataLabel.Text = FirstNameList[randIndexForFirstName];
            LastNameDataLabel.Text = LastNameList[randIndexForLastName];


        }

        private void SaveToolStripButton_Click(object sender, EventArgs e)
        {
            using (StreamWriter outputStream = new StreamWriter(
             File.Open("CharacterGen.txt", FileMode.Create)))
            {
               // outputStream.WriteLine(Program.)



            }
            MessageBox.Show("File saved succesfully","Saving",MessageBoxButtons.OK);
        }

        private void HelpToolStripButton_Click(object sender, EventArgs e)
        {
            Program.aboutBox.ShowDialog();
        }

        private void OpenToolStripButton_Click(object sender, EventArgs e)
        {
            using (StreamReader inputStream = new StreamReader(
           File.Open("CharacterGen.txt", FileMode.Open)))
            {
               // inputStream.ReadLine\



            }
        }

        private void GenerateAbilitiesButton_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            int random1 = rand.Next(0, 16);
            int random2 = rand.Next(0, 16);
            int random3 = rand.Next(0, 16);
            int random4 = rand.Next(0, 16);
            int random5 = rand.Next(0, 16);
            int random6 = rand.Next(0, 16);

            StrengthDataLabel.Text = random1.ToString();
            DexDataLabel.Text = random2.ToString();
            EnduranceDataLabel.Text = random3.ToString();
            IntellectDataLabel.Text = random4.ToString();
            EducationDataLabel.Text = random5.ToString();
            SocialDataLabel.Text = random6.ToString();
        }
    }
}
