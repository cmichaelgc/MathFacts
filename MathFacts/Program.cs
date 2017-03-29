using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathFacts
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Math Facts App";
            int choice = 0;
            Addition addTable = new Addition();
            Multiplication timesTable = new Multiplication();
            do
            {
                MainAppTitle();
                choice = MainMenu();

                if (choice == 1)
                {
                    bool continueChoice = true;
                    int startNum = 0;
                    int endNum = 0;
                    do
                    {
                        addTable.AdditionTitle();
                        try
                        {
                            Console.WriteLine("Enter your starting number");
                            startNum = Int32.Parse(Console.ReadLine());
                            Console.WriteLine("Enter your ending number");
                            endNum = Int32.Parse(Console.ReadLine());
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Please enter a valid number");
                            Console.ReadLine();
                            
                        }
                        finally
                        {
                            if (startNum > 0 && endNum <= 10)
                            {
                                addTable.AdditionTitle();
                                Console.WriteLine("");
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.Write("Your addition Table for {0} - {1}!", startNum, endNum);
                                Console.WriteLine("");
                                addTable.AdditionTable(startNum, endNum);

                                Console.WriteLine("");
                                try
                                {
                                    Console.ForegroundColor = ConsoleColor.Blue;
                                    Console.WriteLine("Would you like more addition facts [y/n]?");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    string moreFacts = Console.ReadLine();
                                    if (moreFacts == "y")
                                    {
                                        continueChoice = true;
                                    }
                                    else if (moreFacts == "n")
                                    {
                                        continueChoice = false;
                                    }
                                }
                                catch (Exception)
                                {

                                    throw;
                                }
                            }
                        }

                    } while (continueChoice == true);

                }
                if(choice == 2)
                {
                    bool continueChoice = true;
                    int startNum = 0;
                    int endNum = 0;
                    do
                    {
                        timesTable.MultiplicationTitle();
                        try
                        {
                            Console.WriteLine("Enter your starting number.");
                            startNum = Int32.Parse(Console.ReadLine());
                            Console.WriteLine("Enter your ending number.");
                            endNum = Int32.Parse(Console.ReadLine());
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Please enter a valid number.");
                            Console.ReadLine();
                            
                        }
                        finally
                        {
                            if (startNum > 0 & endNum <= 10)
                            {
                                timesTable.MultiplicationTitle();
                                Console.WriteLine("");
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("Your multiplication table for {0} - {1}.", startNum, endNum);
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("");
                                timesTable.MultiplicationTable(startNum, endNum);

                                Console.WriteLine("");
                                try
                                {
                                    Console.ForegroundColor = ConsoleColor.Blue;
                                    Console.WriteLine("Would you like more multiplication facts? [y/n]");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    string moreFacts = Console.ReadLine();
                                    if (moreFacts == "y")
                                    {
                                        continueChoice = true;
                                    }
                                    else if (moreFacts == "n")
                                    {
                                        continueChoice = false;
                                    }
                                }
                                catch (Exception)
                                {

                                    throw;
                                }
                            }
                        }
                    } while (continueChoice == true);
                }
            } while (choice != 3);
        }
        private static int MainMenu()
        {
            int choice;
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Select an option");
            Console.WriteLine("=================");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Option 1: Addition Facts");
            Console.WriteLine("Option 2: Multiplication Facts");
            Console.WriteLine("Option 3: Leave Math Facts");
            //TODO - fix the exception handling
            choice = Int32.Parse(Console.ReadLine());
            return choice;
        }
        private static void MainAppTitle()
        {
            Console.Clear();
            string appTitle = @"
         _____          __  .__      ___________              __          
        /     \ _____ _/  |_|  |__   \_   _____/____    _____/  |_  ______
       /  \ /  \\__  \\   __\  |  \   |    __) \__  \ _/ ___\   __\/  ___/
      /    Y    \/ __ \|  | |   Y  \  |     \   / __ \\  \___|  |  \___ \ 
      \____|__  (____  /__| |___|  /  \___  /  (____  /\___  >__| /____  >
              \/     \/          \/       \/        \/     \/          \/ 
                              _____                 
                             /  _  \ ______ ______  
                            /  /_\  \\____ \\____ \ 
                           /    |    \  |_> >  |_> >
                           \____|__  /   __/|   __/ 
                                   \/|__|   |__|    ";


            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(appTitle);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}//build a 4th loop for division table.
