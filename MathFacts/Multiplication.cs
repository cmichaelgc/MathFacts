using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathFacts
{
    class Multiplication
    {
        public void MultiplicationTitle()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            string appTitle = @"

                       ___    __                ___                         __                           
      /'\_/`\         /\_ \  /\ \__  __        /\_ \    __                 /\ \__  __                    
     /\      \  __  __\//\ \ \ \ ,_\/\_\  _____\//\ \  /\_\    ___     __  \ \ ,_\/\_\    ___     ___    
     \ \ \__\ \/\ \/\ \ \ \ \ \ \ \/\/\ \/\ '__`\\ \ \ \/\ \  /'___\ /'__`\ \ \ \/\/\ \  / __`\ /' _ `\  
      \ \ \_/\ \ \ \_\ \ \_\ \_\ \ \_\ \ \ \ \L\ \\_\ \_\ \ \/\ \__//\ \L\.\_\ \ \_\ \ \/\ \L\ \/\ \/\ \ 
       \ \_\\ \_\ \____/ /\____\\ \__\\ \_\ \ ,__//\____\\ \_\ \____\ \__/.\_\\ \__\\ \_\ \____/\ \_\ \_\
        \/_/ \/_/\/___/  \/____/ \/__/ \/_/\ \ \/ \/____/ \/_/\/____/\/__/\/_/ \/__/ \/_/\/___/  \/_/\/_/
                                            \ \_\                                                        
                                             \/_/                                                        
                                   ______          __       ___             
                                  /\__  _\        /\ \     /\_ \            
                                  \/_/\ \/    __  \ \ \____\//\ \      __   
                                     \ \ \  /'__`\ \ \ '__`\ \ \ \   /'__`\ 
                                      \ \ \/\ \L\.\_\ \ \L\ \ \_\ \_/\  __/ 
                                       \ \_\ \__/.\_\\ \_,__/ /\____\ \____\
                                        \/_/\/__/\/_/ \/___/  \/____/\/____/";

            Console.WriteLine(appTitle);
            Console.WriteLine("");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("You will be able to select a starting number and an ending number between 1 - 10.");
            Console.WriteLine("Next you will see the numbers between these selections be multiplied");
            Console.WriteLine("to numbers 1 - 10.");
            Console.WriteLine("");
            Console.WriteLine("Select a starting number between 1 and 10.");
            Console.WriteLine("==========================================");
        }

        public void MultiplicationTable(int startNum, int endNum)
        {
            for (int i = startNum - 1; i <= endNum; i++)
            {
                if (i == startNum - 1)
                {
                    Console.Write(String.Format("{0, 6}", "n"));
                }
                else
                {
                    Console.Write(String.Format("{0, 6}", i));
                }


            }
            Console.WriteLine("\n");
            for (int i = 1; i <= 10; i++)
            {
                Console.Write(String.Format("{0, 6}", i));
                for (int b = startNum; b <= endNum; b++)
                {
                    string output = String.Format("{0, 6}", i * b);
                    Console.Write(output);
                }
                Console.WriteLine("");
            }
        }
    }
}
