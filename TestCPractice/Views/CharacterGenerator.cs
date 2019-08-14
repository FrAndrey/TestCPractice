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

        private void GenerateNameButton_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            //Here instead of tabcontrol should be numberOfLines of Names
            int randomIndex = rand.Next(0, MainTabControl.TabPages.Count - 1); 
        }

        private void SaveToolStripButton_Click(object sender, EventArgs e)
        {
            using (StreamWriter outputStream = new StreamWriter(
             File.Open("CharacterGen.txt", FileMode.Create)))
            {
               // outputStream.WriteLine(Program.)



            }
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
