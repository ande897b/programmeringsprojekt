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

            Console.WriteLine("For english press 1 followed by enter, for danish press 2 followed by enter");
            char valgIMenu;
            bool menuBool = true;
            int counter = 0;
            string line;
            char input;
            bool restart = true;

            while (menuBool)
            {
                valgIMenu = char.Parse(Console.ReadLine());

                if (valgIMenu == '1')
                {


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
                        else if (input == '4')
                        {
                            Console.WriteLine(Functions.GetTheAnswerToLifeTheUniverseAndEverything());
                            restart = false;
                        }
                        else if (input == '0')
                        {
                            Environment.Exit(0);
                        }
                        else
                        {
                            Console.WriteLine("Input proper value");
                        }
                    }
                    menuBool = false;
                }
                else if (valgIMenu == '2')
                {
                    // Functions functions = new Functions();
                    System.IO.StreamReader file = new System.IO.StreamReader(@"C:\Users\Anders\Desktop\gittest\pc1\SmartMenuApp.Code-master\MenuSpecDK.txt");
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
                        else if (input == '4')
                        {
                            Console.WriteLine(Functions.GetTheAnswerToLifeTheUniverseAndEverything());
                            restart = false;
                        }
                        else if (input =='0')
                        {
                            Environment.Exit(0);
                        }
                        else
                        {
                            Console.WriteLine("Input proper value");
                        }
                    }
                    menuBool = false;
                }
                
                

                else
                {
                    Console.WriteLine("Input Proper Value");
                }

            }
        }
    }
}