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
         File.Open("Data/firstNames.txt", FileMode.Open)))
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
     File.Open("Data/lastNames.txt", FileMode.Open)))
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


        private void GenerateNameButton_Click(object sender, EventArgs e)
        {
            // int randomIndex = rand.Next(0, MainTabControl.TabPages.Count - 1); 

            List<string> FirstNameList = new List<string>();
            List<string> LastNameList = new List<string>();

       
            randFirstName.Next(0, FirstNameList.Count - 1);
            randLastName.Next(0, LastNameList.Count - 1);




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
    }
}
