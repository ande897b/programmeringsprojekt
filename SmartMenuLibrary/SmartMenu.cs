using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartMenuLibrary
{
    public class SmartMenu
    {
        public void LoadMenu(string path)
        {
            System.IO.StreamReader file = new System.IO.StreamReader(@"C:\Users\emil0\source\repos\ProjektProgrammering1(Anders,Kasper,Emil)\programmeringsprojekt\MenuSpecEN.txt");
        }
        public void Activate()
        {
            int counter = 0;
            string line;
            System.IO.StreamReader file = new System.IO.StreamReader(@"C:\Users\emil0\source\repos\ProjektProgrammering1(Anders,Kasper,Emil)\programmeringsprojekt\MenuSpecEN.txt");
            while ((line = file.ReadLine()) != null)
            {
                Console.WriteLine(line);
                counter++;
            }
        }
    }
}
