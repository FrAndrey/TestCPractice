using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestCPractice.Views;
using System.Collections.Generic;
using TestCPractice.Objects;

namespace TestCPractice
{
    public  class Program
    {
        //temporary
       public static  CharacterGenerator characterForm;
        public static AboutBox aboutBox;
        public static CharacterPortfolio character;
        
       


        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            characterForm = new CharacterGenerator();
            aboutBox = new AboutBox();
            




            Application.Run(characterForm);
        }
    }
}
