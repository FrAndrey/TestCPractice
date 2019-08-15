﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.IO;
using System.Diagnostics;
/*
Andrey Paramonov
ID: 301038409
Descr: This is a main container class for an application
*/
namespace TestCPractice.Objects
{
   public class CharacterPortfolio 
    {
        //Identity
        public Identity Identity { get; set; }


        //characteristics
        public string Strength { get; set; }
        public string Dexterity { get; set; }
        public string Endurance { get; set; }
        public string Intellect { get; set; }
        public string Education { get; set; }
        public string SocialStanding { get; set; }

        //Skill List

        List<Skill> Skills;

       /* CharacterPortfolio()
        {
            //Construction
            this.Skills = new List<Skill>();
            this.Identity = new Identity();
            
        } */
    }
}
