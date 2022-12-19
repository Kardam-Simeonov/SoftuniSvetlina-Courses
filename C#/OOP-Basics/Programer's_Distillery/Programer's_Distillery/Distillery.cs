using System;
using System.Collections.Generic;
using System.Linq;

namespace Programer_s_Distillery
{
    internal class Distillery
    {
        private string name;
        private Batch<Drink> drinkBatch;

        public Batch<Drink> DrinkBatch
        {
            get { return drinkBatch; }
            set { drinkBatch = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Distillery(string name)
        {
            this.Name = name;
            drinkBatch = new Batch<Drink>();
        }

        public void Add()
        {
            if (DrinkBatch.LastIndex == 4)
                Screen.Error("Batch full of drinks");

            Screen.ClearWorkingArea();
            Console.Write("Enter the drink's name: ");
            string drinkName = Console.ReadLine();

            for (int i = 0; i < DrinkBatch.LastIndex; i++)
                if (drinkBatch[i].Name == drinkName)
                    Screen.Error($"Drink {drinkName} already exists");
          
            Screen.ClearWorkingArea();

            decimal remainingPoints = 1;
            decimal[] ratio = new decimal[4];
            string[] ratioNames = { "Code Skill(1/4)", "Algo Skill(2/4)", "XP Skill(3/4)", "Language Skill(4/4)" };

            for (int i = 0; i < 4; i++)
            {
                if (remainingPoints <= 0)
                    Screen.Error("Invalid concentration ratio");

                Screen.ClearWorkingArea();
                Console.WriteLine($"{remainingPoints:F2} POINTS REMAINING");
                Console.Write($"Assign points for {ratioNames[i]}: ");
                decimal inputPoints = decimal.Parse(Console.ReadLine());

                remainingPoints -= inputPoints;
                ratio[i] = inputPoints;
            }

            Drink drinkToAdd = new Drink(drinkName, ratio[0], ratio[1], ratio[2], ratio[3]);

            DrinkBatch.Add(drinkToAdd);
            Screen.drinksCount++;

            Screen.ClearWorkingArea();
            Console.WriteLine("SUCCESS");
            Console.WriteLine($"Drink added: {drinkToAdd}");
            
            System.Threading.Thread.Sleep(500);

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        public void Remove()
        {
            Screen.ClearWorkingArea();
            Console.Write("Enter the drink's name: ");

            Drink drinkToRemove = Find(Console.ReadLine());

            DrinkBatch.Remove(drinkToRemove);
            Screen.drinksCount--;

            Screen.ClearWorkingArea();
            Console.WriteLine("SUCCESS");
            Console.WriteLine($"Drink removed: {drinkToRemove}");

            System.Threading.Thread.Sleep(500);

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        public void Edit()
        {
            Screen.ClearWorkingArea();
            Console.Write("Enter the drink's name: ");

            Drink drinkToEdit = Find(Console.ReadLine());
            
            Screen.ClearWorkingArea();
            Console.WriteLine("What part to edit?");
            Console.WriteLine(" 1) Name");
            Console.WriteLine(" 2) Concentration");

            string command = Console.ReadLine();

            if (command == "1")
            {
                Console.Write("Enter the new name: ");
                drinkToEdit.Name = Console.ReadLine();
            }
            else if (command == "2")
            {
                decimal remainingPoints = 1;
                decimal[] ratio = new decimal[4];
                string[] ratioNames = { "Code Skill(1/4)", "Algo Skill(2/4)", "XP Skill(3/4)", "Language Skill(4/4)" };

                for (int i = 0; i < 4; i++)
                {
                    if (remainingPoints <= 0)
                        Screen.Error("Invalid concentration ratio");

                    Screen.ClearWorkingArea();
                    Console.WriteLine($"{remainingPoints:F2} POINTS REMAINING");
                    Console.Write($"Assign points for {ratioNames[i]}: ");
                    decimal inputPoints = decimal.Parse(Console.ReadLine());

                    remainingPoints -= inputPoints;
                    ratio[i] = inputPoints;
                }

                drinkToEdit.CodeSkill = ratio[0];
                drinkToEdit.AlgoSkill = ratio[1];
                drinkToEdit.XPSkill = ratio[2];
                drinkToEdit.LanguageSkill = ratio[3];
            }


            Screen.ClearWorkingArea();
            Console.WriteLine("SUCCESS");
            Console.WriteLine($"Drink edited: {drinkToEdit}");

            System.Threading.Thread.Sleep(500);

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
        
        public void Fuse()
        {
            Screen.ClearWorkingArea();
            Console.Write("Enter the first drink's name: ");
            Drink firstDrink = Find(Console.ReadLine());

            Screen.ClearWorkingArea();
            Console.Write("Enter the second drink's name: ");
            Drink secondDrink = Find(Console.ReadLine());

            Screen.ClearWorkingArea();
            Console.Write("Enter the new drink's name: ");

            decimal codeSkill = (firstDrink.CodeSkill + secondDrink.CodeSkill) / 2;
            decimal algoSkill = (firstDrink.AlgoSkill + secondDrink.AlgoSkill) / 2;
            decimal xpSkill = (firstDrink.XPSkill + secondDrink.XPSkill) / 2;
            decimal languageSkill = (firstDrink.LanguageSkill + secondDrink.LanguageSkill) / 2;

            Drink fusedDrink = new Drink(Console.ReadLine(), codeSkill, algoSkill, xpSkill, languageSkill);

            DrinkBatch.Remove(firstDrink);
            DrinkBatch.Remove(secondDrink);
            DrinkBatch.Add(fusedDrink);

            Screen.drinksCount--;

            Screen.ClearWorkingArea();
            Console.WriteLine("SUCCESS");
            Console.WriteLine($"Fused drink: {fusedDrink}");
            Console.WriteLine($"Removed drinks: {firstDrink} and {secondDrink}");

            System.Threading.Thread.Sleep(500);

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        public void Compare()
        {
            Screen.ClearWorkingArea();
            Console.Write("Enter the first drink's name: ");
            Drink firstDrink = Find(Console.ReadLine());

            Screen.ClearWorkingArea();
            Console.Write("Enter the second drink's name: ");
            Drink secondDrink = Find(Console.ReadLine());

            int result = firstDrink.CompareTo(secondDrink);

            if (result > 0)
            {
                Screen.ClearWorkingArea();
                Console.WriteLine("SUCCESS");
                Console.WriteLine($"{firstDrink} is better than {secondDrink}");

                System.Threading.Thread.Sleep(500);

                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
            else if (result < 0)
            {
                Screen.ClearWorkingArea();
                Console.WriteLine("SUCCESS");
                Console.WriteLine($"{secondDrink} is better than {firstDrink}");

                System.Threading.Thread.Sleep(500);

                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
            else
            {
                Screen.ClearWorkingArea();
                Console.WriteLine("SUCCESS");
                Console.WriteLine($"{firstDrink} is equal to {secondDrink}");

                System.Threading.Thread.Sleep(500);

                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }

        }

        public void ViewBatch()
        {
            Screen.ClearWorkingArea();
            Console.WriteLine($"{name} Distillery");
            Console.WriteLine("Drink Batch");
            Console.WriteLine("==================");

            for (int i = 0; i < 4; i++)
                if (drinkBatch[i] == null)
                    Console.WriteLine($"{i}) [EMPTY]");
                else
                    Console.WriteLine($"{i}) {drinkBatch[i]}");

            Console.WriteLine();
            System.Threading.Thread.Sleep(500);

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        public void BestDrink()
        {
            if (DrinkBatch.LastIndex == 0)
                Screen.Error("No drinks in batch");

            Drink bestDrink = DrinkBatch[0];

            for (int i = 1; i < DrinkBatch.LastIndex; i++)
            {
                if (DrinkBatch[i].CompareTo(bestDrink) > 0)
                    bestDrink = DrinkBatch[i];
            }

            Screen.ClearWorkingArea();
            Console.WriteLine("SUCCESS");
            Console.WriteLine($"{bestDrink} is the best drink in the batch");

            System.Threading.Thread.Sleep(500);

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        public void WorstDrink()
        {
            if (DrinkBatch.LastIndex == 0)
                Screen.Error("No drinks in batch");

            Drink worstDrink = DrinkBatch[0];

            for (int i = 1; i < DrinkBatch.LastIndex; i++)
            {
                if (DrinkBatch[i].CompareTo(worstDrink) < 0)
                    worstDrink = DrinkBatch[i];
            }

            Screen.ClearWorkingArea();
            Console.WriteLine("SUCCESS");
            Console.WriteLine($"{worstDrink} is the worst drink in the batch");

            System.Threading.Thread.Sleep(500);

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        public void AverageStats()
        {
            if (DrinkBatch.LastIndex == 0)
                Screen.Error("No drinks in batch");

            int count = 0;
            decimal averageCode = 0;
            decimal averageAlgo = 0;
            decimal averageXP = 0;
            decimal averageLanguage = 0;

            for (int i = 0; i < drinkBatch.LastIndex; i++)
            {
                averageCode += drinkBatch[i].CodeSkill;
                averageAlgo += drinkBatch[i].AlgoSkill;
                averageXP += drinkBatch[i].XPSkill;
                averageLanguage += drinkBatch[i].LanguageSkill;

                count++;
            }

            averageCode /= count;
            averageAlgo /= count;
            averageXP /= count;
            averageLanguage /= count;

            Screen.ClearWorkingArea();
            Console.WriteLine("SUCCESS");
            Console.WriteLine($"Average ratio in batch: {averageCode:F2}/{averageAlgo:F2}/{averageXP:F2}/{averageLanguage:F2}");


            System.Threading.Thread.Sleep(500);

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        public void SellBatch()
        {
            if (DrinkBatch.LastIndex != 4)
                Screen.Error("Batch is not full");

            Screen.ClearWorkingArea();
            Console.WriteLine($"{name} Distillery");
            Console.WriteLine("Drink Batch");
            Console.WriteLine("==================");

            for (int i = 0; i < 4; i++)
                    Console.WriteLine($"{i}) {drinkBatch[i]}");

            Console.WriteLine();

            Console.WriteLine("Are you sure you want to sell? y/n");
            
            if (Console.ReadLine() == "y")
            {
                double qualityCoefficient = CalculateQuality();
                double totalPrice = 0;

                for (int i = 0; i < 4; i++)
                    totalPrice += 100 * drinkBatch[i].GetHighestElement();
                

                Screen.ClearWorkingArea();
                Console.WriteLine("===SUCCESSFUL SALE===");

                for (int i = 0; i < 4; i++)
                    Console.WriteLine($"{i}) {drinkBatch[i]} => {100 * drinkBatch[i].GetHighestElement()}lv");

                Console.WriteLine();
                Console.WriteLine($"QUALITY COEFFICIENT => {qualityCoefficient}");
                Console.WriteLine($"TOTAL => {totalPrice * qualityCoefficient:F2}lv");

                DrinkBatch = new Batch<Drink>();
                Screen.drinksCount = 0;

                System.Threading.Thread.Sleep(2000);

                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
        }

        public double CalculateQuality()
        {
            
            switch (DrinkBatch.UniqueItems())
            {
                case 4:
                    if (DrinkBatch.OrderBy(x => x) == DrinkBatch)
                        return 2;
                    return 1.85;                 
                case 3:
                    return 1.5;                   
                case 2:
                    return 1.25;                   
                case 1:
                    return 1;      
                default:
                    break;
            }

            return 1;
        }

        public Drink Find(string name)
        {
            foreach (var drink in this.DrinkBatch)
            {
                if (drink != null)
                {
                    if (drink.Name == name)
                    {
                        return drink;
                    }
                }
            }

            Screen.Error("Drink not found in batch");
            return null; 
        }
    }
}