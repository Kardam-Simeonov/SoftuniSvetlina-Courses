using System;

namespace Programer_s_Distillery
{
    internal static class Screen
    {
        public static int drinksCount;

        static string[] openingTitle = new string[]
        {
            @"  _____                                                         _     ",
            @" |  __ \                                                       ( )    ",
            @" | |__) | __ ___   __ _ _ __ __ _ _ __ ___  _ __ ___   ___ _ __|/ ___ ",
            @" |  ___/ '__/ _ \ / _` | '__/ _` | '_ ` _ \| '_ ` _ \ / _ \ '__| / __|",
            @" | |   | | | (_) | (_| | | | (_| | | | | | | | | | | |  __/ |    \__ \",
            @" |_|   |_|  \___/ \__, |_|  \__,_|_| |_| |_|_| |_| |_|\___|_|    |___/",
            @"                   __/ |                                              ",
            @"                  |___/                                               ",
            @"  _____  _     _   _ _ _                     #                        ",
            @" |  __ \(_)   | | (_) | |                   :#:                       ",
            @" | |  | |_ ___| |_ _| | | ___ _ __ _   _    : :                       ",
            @" | |  | | / __| __| | | |/ _ \ '__| | | |   : :                       ",
            @" | |__| | \__ \ |_| | | |  __/ |  | |_| | .'   '.                     ",
            @" |_____/|_|___/\__|_|_|_|\___|_|   \__, | :_____:  .___. .___.        ",
            @"                                   __/ |  |     |  |   | |   |        ",
            @"                                  |___/   |     |  '. .' '. .'        ",
            @"                                          |     |    |     |          ",
            @"                                          |_____|    |     |          ",
            @"                                          :_____:   -'-   -'-         ",
            @"======================================================================"
        };

        static string[] drinksEmpty = new string[]
        {
            @"    #",
            @"   :#:",
            @"   : :",
            @"   : :",
            @" .'   '.",
            @" :_____:  .___. .___. .___. .___.",
            @" |     |  |   | |   | |   | |   |",
            @" |     |  '. .' '. .' '. .' '. .",
            @" |     |    |     |     |     |",
            @" |_____|    |     |     |     |",
            @" :_____:   -'-   -'-   -'-   -'-",
            @"=================================="
        };

        static string[] drinksOne = new string[]
        {
            @"    #",
            @"   :#:",
            @"   : :",
            @"   : :",
            @" .'   '.",
            @" :_____:  .___. .___. .___. .___.",
            @" |     |  |###| |   | |   | |   |",
            @" |     |  '.#.' '. .' '. .' '. .",
            @" |     |    |     |     |     |",
            @" |_____|    |     |     |     |",
            @" :_____:   -'-   -'-   -'-   -'-",
            @"=================================="
        };

        static string[] drinksTwo = new string[]
        {
            @"    #",
            @"   :#:",
            @"   : :",
            @"   : :",
            @" .'   '.",
            @" :_____:  .___. .___. .___. .___.",
            @" |     |  |###| |###| |   | |   |",
            @" |     |  '.#.' '.#.' '. .' '. .",
            @" |     |    |     |     |     |",
            @" |_____|    |     |     |     |",
            @" :_____:   -'-   -'-   -'-   -'-",
            @"=================================="
        };

        static string[] drinksThree = new string[]
        {
            @"    #",
            @"   :#:",
            @"   : :",
            @"   : :",
            @" .'   '.",
            @" :_____:  .___. .___. .___. .___.",
            @" |     |  |###| |###| |###| |   |",
            @" |     |  '.#.' '.#.' '.#.' '. .",
            @" |     |    |     |     |     |",
            @" |_____|    |     |     |     |",
            @" :_____:   -'-   -'-   -'-   -'-",
            @"=================================="
        };

        static string[] drinksFour = new string[]
        {
            @"    #",
            @"   :#:",
            @"   : :",
            @"   : :",
            @" .'   '.",
            @" :_____:  .___. .___. .___. .___.",
            @" |     |  |###| |###| |###| |###|",
            @" |     |  '.#.' '.#.' '.#.' '.#.",
            @" |     |    |     |     |     |",
            @" |_____|    |     |     |     |",
            @" :_____:   -'-   -'-   -'-   -'-",
            @"=================================="
        };

        public static string Initialize()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            TypeWriter(openingTitle, 100);
            Console.WriteLine();
            Console.Write("Enter Distillery Name: ");

            return Console.ReadLine();
        }

        public static string DrawScreen()
        {
            Console.Clear();

            switch (drinksCount)
            {
                case 0:
                    TypeWriter(drinksEmpty, 50);
                    break;
                case 1:
                    TypeWriter(drinksOne, 50);
                    break;
                case 2:
                    TypeWriter(drinksTwo, 50);
                    break;
                case 3:
                    TypeWriter(drinksThree, 50);
                    break;
                case 4:
                    TypeWriter(drinksFour, 50);
                    break;

            }
            Console.WriteLine();
            Console.WriteLine("1) Add");
            Console.WriteLine("2) Remove");
            Console.WriteLine("3) Edit");
            Console.WriteLine("4) Fuse");
            Console.WriteLine("5) Compare");
            Console.WriteLine("6) View Batch");
            Console.WriteLine("7) View Best Drink");
            Console.WriteLine("8) View Worst Drink");
            Console.WriteLine("9) View Average Stats");
            Console.WriteLine("10) Sell Batch");
            Console.WriteLine();

            return Console.ReadLine();
        } 

        public static void Error(string message)
        {
            ClearWorkingArea();
            Console.WriteLine($"Error! {message}");
            System.Threading.Thread.Sleep(500);

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();

            StartUp.Menu();
        }

        public static void ClearWorkingArea()
        {
            int currentLineCursor = Console.CursorTop;

            for (int i = 13; i < 28; i++)
            {
                Console.SetCursorPosition(0, i);
                Console.Write(new string(' ', Console.WindowWidth));
            }

            Console.SetCursorPosition(0, 13);
        }

        public static void TypeWriter(string[] arr, int delay)
        {
            foreach (string element in arr)
            {
                Console.WriteLine(element);
                System.Threading.Thread.Sleep(delay);
            }
        }
    }
}