﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
/*
 * Andrey Paramonov
 * ID: 301038409
 * This is a Main Form for all the application Features
 * */
namespace TestCPractice.Views
{
    public partial class CharacterGenerator : TestCPractice.Views.MasterForm
    {
        List<string> FirstNameList = new List<string>();
        List<string> LastNameList = new List<string>();
        List<string> SkillList = new List<string>();

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
        /// <summary>
        /// This is a method for LoadNames from text files
        /// </summary>
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

        /// <summary>
        /// This is a method for generation names
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GenerateNames(object sender, EventArgs e)
        {
            LoadNames();
            Random randFirst = new Random();
            Random randLast = new Random();
     
            int randIndexForFirstName = randFirst.Next(0, FirstNameList.Count - 1);
            int randIndexForLastName = randLast.Next(0, LastNameList.Count - 1);

            Program.identity.FirstName = FirstNameDataLabel.Text = FirstNameList[randIndexForFirstName];
            Program.identity.LastName = LastNameDataLabel.Text = LastNameList[randIndexForLastName];
            


        }

        private void SaveToolStripButton_Click(object sender, EventArgs e)
        {
         
            MessageBox.Show("File saved succesfully","Saving",MessageBoxButtons.OK);
     
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

        //    Program.character.Strength = StrengthDataLabel.ToString();
        //    Program.character.Dexterity = DexDataLabel.ToString();
       //     Program.character.Endurance = EnduranceDataLabel.ToString();
        //    Program.character.Intellect = IntellectDataLabel.ToString();
         //   Program.character.Education = EducationDataLabel.ToString();
        //    Program.character.SocialStanding = SocialDataLabel.ToString();
        }
        private void LoadSkills()
        {

            using (StreamReader inputSkillsStream = new StreamReader(
     File.Open("skills.txt", FileMode.Open)))
            {
                string line;
                int counter = 0;
                while ((line = inputSkillsStream.ReadLine()) != null)
                {
                    SkillList.Add(line);
                    counter++;
                }
                inputSkillsStream.Close();
                inputSkillsStream.Dispose();
            }


        }
        private void GenerateSkillsButton_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            int random1 = rand.Next(0, SkillList.Count - 1);
            int random2 = rand.Next(0, SkillList.Count - 1);
            int random3 = rand.Next(0, SkillList.Count - 1);
            int random4 = rand.Next(0, SkillList.Count - 1);

            FirstDataLabel.Text = SkillList[random1];
            SecondDataLabel.Text = SkillList[random2];
            ThirdDataLabel.Text = SkillList[random3];
            FourthDataLabel.Text = SkillList[random4];
        }

        private void CharacterGenerator_Load(object sender, EventArgs e)
        {
            LoadSkills();
        


        }

        private void MainTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MainTabControl.SelectedIndex == 3)
            {
                FNameDataLabel.Text = Program.identity.FirstName;
                LNameDataLabel.Text = Program.identity.LastName;

            }

        }
    }
}
