using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathFacts
{
    class Division
    {
        public void DivisionTitle()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            string appTitle = @"
               ______  _________         _________ _______ _________ _______  _       
              (  __  \ \__   __/|\     /|\__   __/(  ____ \\__   __/(  ___  )( (    /|
              | (  \  )   ) (   | )   ( |   ) (   | (    \/   ) (   | (   ) ||  \  ( |
              | |   ) |   | |   | |   | |   | |   | (_____    | |   | |   | ||   \ | |
              | |   | |   | |   ( (   ) )   | |   (_____  )   | |   | |   | || (\ \) |
              | |   ) |   | |    \ \_/ /    | |         ) |   | |   | |   | || | \   |
              | (__/  )___) (___  \   /  ___) (___/\____) |___) (___| (___) || )  \  |
              (______/ \_______/   \_/   \_______/\_______)\_______/(_______)|/    )_)
                                                                                      
                           _________ _______  ______   _        _______ 
                           \__   __/(  ___  )(  ___ \ ( \      (  ____ \
                              ) (   | (   ) || (   ) )| (      | (    \/
                              | |   | (___) || (__/ / | |      | (__    
                              | |   |  ___  ||  __ (  | |      |  __)   
                              | |   | (   ) || (  \ \ | |      | (      
                              | |   | )   ( || )___) )| (____/\| (____/\
                              )_(   |/     \||/ \___/ (_______/(_______/";

            Console.WriteLine(appTitle);
            Console.WriteLine("");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("You will be able to select a starting number and an ending number between 1 - 10.");
            Console.WriteLine("Next you will see the numbers between these selections be divided");
            Console.WriteLine("to numbers 1 - 10.");
            Console.WriteLine("");
            Console.WriteLine("Select a starting number between 1 and 10.");
            Console.WriteLine("==========================================");
        }

        public void DivisionTable(int startNum, int endNum)
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
                    string output = String.Format("{0, 6}", i / b);
                    Console.Write(output);
                }
                Console.WriteLine("");
            }

        }
    }
}
