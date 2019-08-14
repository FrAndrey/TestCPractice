using System;
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
Descr: This is an Identity class for an application
*/
namespace TestCPractice.Objects
{
    public class Identity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }


        List<string> FirstNameList = new List<string>();
        List<string> LastNameList = new List<string>();

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
    }
}
