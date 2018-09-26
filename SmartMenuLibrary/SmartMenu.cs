using FunctionLibrary;
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
            System.IO.StreamReader file = new System.IO.StreamReader(@"C:\Users\Anders\Desktop\gittest\pc1\SmartMenuApp.Code-master\MenuSpecEN.txt");
        }
        public void Activate()
        {
            int counter = 0;
            string line;
            char input;
            bool restart = true;
            // Functions functions = new Functions();
            System.IO.StreamReader file = new System.IO.StreamReader(@"C:\Users\Anders\Desktop\gittest\pc1\SmartMenuApp.Code-master\MenuSpecEN.txt");
            while ((line = file.ReadLine()) != null)
            {
                Console.WriteLine(line);
                counter++;
            }
            while (restart)
            {
                input = char.Parse(Console.ReadLine());

                if (input == '1')
                {
                    Console.WriteLine(Functions.DoThis());
                    restart = false;
                }

               else if (input == '2')
                {
                    Console.WriteLine(Functions.DoThat());
                    restart = false;
                }
               else if (input == '3')
                {
                    string inputTilDoSomething = Console.ReadLine();
                    // Functions.DoSomething(inputTilDoSomething);
                    Console.WriteLine(Functions.DoSomething(inputTilDoSomething));
                    restart = false;
                }
              else  if (input == '4')
                {
                    Console.WriteLine(Functions.GetTheAnswerToLifeTheUniverseAndEverything());
                    restart = false;
                }               
                else 
                {
                    Console.WriteLine("Input proper value");                    
                }
            }
        }
    }
}
