using System;
using System.Collections.Generic;
using System.Linq;

namespace WordSearch
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            List<string> strList = new List<string>();
            string[] words = new string[] { "BLAME", "VOICE", "LEAD", "NICE" };
            strList.AddRange(words);


            Console.WriteLine("C M L A M");
            Console.WriteLine("A B O E D");
            Console.WriteLine("I T N D G");
            Console.WriteLine("C Y V I A");
            Console.WriteLine("L E C O L");
            Console.WriteLine("\n Were you able to find some words? \n");
            

            while(strList.Count != 0)
            {
                string name = Console.ReadLine();
                if (name != "BLAME" && name != "VOICE" && name != "LEAD" && name != "NICE")
                {
                    Console.WriteLine("Try again");
                    
                }
                else if (strList.Contains(name))
                {
                    strList.Remove(name);
                    if (strList.Count() == 0)
                    {
                        Console.WriteLine("CONGRATULATIONS!!!!!");
                    }
                    else if (strList.Count() != 0)
                    {
                        Console.WriteLine("You have " + strList.Count() + " more");
                        Console.WriteLine("you wanna finish the game");

                    }


                }
            }
        }
    }
}
