using System;
using System.Linq;

namespace Programer_s_Distillery
{
    internal class StartUp
    {
        public static Distillery distillery;
        static void Main(string[] args)
        {
            distillery = new Distillery(Screen.Initialize());
            Menu();
        }
        
        public static void Menu()
        {
            while (true)
            {
                switch (Screen.DrawScreen())
                {
                    case "1":
                        distillery.Add();
                        break;
                    case "2":
                        distillery.Remove();
                        break;
                    case "3":
                        distillery.Edit();
                        break;
                    case "4":
                        distillery.Fuse();
                        break;
                    case "5":
                        distillery.Compare();
                        break;
                    case "6":
                        distillery.ViewBatch();
                        break;
                    case "7":
                        distillery.BestDrink();
                        break;
                    case "8":
                        distillery.WorstDrink();
                        break;
                    case "9":
                        distillery.AverageStats();
                        break;
                    case "10":
                        distillery.SellBatch();
                        break;
                    case "exit":
                        Environment.Exit(0);
                        break;
                }
            }
        }
    }
}
