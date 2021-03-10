using System;

namespace WordsEXAM
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)                        //a while loop is initiated, that will run until broken out of
            {
                string name = Console.ReadLine();        //the string var name is initialized here
                if (name == "done")                      //if the user command is "done"
                {
                    Console.WriteLine("no");            //print out "no", because the length of done cannot be divided by 3 without remainder
                    break;                               //break out of the loop and the program is over
                }
                else if (name.Length % 3 == 0)           // else if the length of the given name can be divided by 3 without remainder
                    Console.WriteLine("yes");            // print out "yes"
                else if (name.Length % 3 != 0)           //else if the length of the given name CANNOT  be divided by 3 without remainder
                    Console.WriteLine("no");             // print out "no"

                                                           
            }
        }
    }
}
