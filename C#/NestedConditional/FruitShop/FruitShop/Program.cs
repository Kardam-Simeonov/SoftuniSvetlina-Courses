using System;

namespace FruitShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine().ToLower();
            string day = Console.ReadLine().ToLower();
            double amount = double.Parse(Console.ReadLine());
            double price = 0;

            if ("monday" == day || "tuesday" == day || "wednesday" == day ||
                "thursday" == day || "friday" == day) 
            { 
                    
                        if (fruit == "banana")
                            price = 2.50;

                        else if (fruit == "apple")
                            price = 1.20;

                        else if (fruit == "orange")
                            price = 0.85;
                           
                        else if (fruit == "grapefruit")
                            price = 1.45;
                           
                        else if (fruit == "kiwi")
                            price = 2.70;
                         
                        else if (fruit == "pineapple")
                            price = 5.50;
            
                        else if (fruit == "grapes")
                            price = 3.85;

                
            }
            
            else if ("saturday" == day || "sunday" == day)
            {
                if (fruit == "banana")
                    price = 2.70;

                else if (fruit == "apple")
                    price = 1.25;

                else if (fruit == "orange")
                    price = 0.90;

                else if (fruit == "grapefruit")
                    price = 1.60;

                else if (fruit == "kiwi")
                    price = 3.00;

                else if (fruit == "pineapple")
                    price = 5.60;

                else if (fruit == "grapes")
                    price = 4.20;

               
            }

            
            if (price > 0)
                Console.WriteLine($"{(price * amount):F2}");
            else
                Console.WriteLine("error");

        }
    }
}
