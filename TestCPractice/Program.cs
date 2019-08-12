using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestCPractice.Views;

namespace TestCPractice
{
    public static class Program
    {
        //temporary
       public static  MasterForm masterForm;


        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            masterForm = new MasterForm();





            Application.Run(masterForm);
        }
    }
}
