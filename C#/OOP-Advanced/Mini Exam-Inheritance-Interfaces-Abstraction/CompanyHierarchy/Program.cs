using System;
using System.Threading;

namespace CompanyHierarchy
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            
            while (input[0] != "End")
            {
                switch (input[2])
                {
                    case "Sales":
                        SalesEmployee inputSalesEmployee = new SalesEmployee(input[0], input[1], input[2], decimal.Parse(input[3]));
                        Console.WriteLine(inputSalesEmployee);
                        Console.WriteLine($"Receives a salary {(inputSalesEmployee.GetSalary()):f1}.");
                        break;

                    case "Engineering":
                        Engineer inputEngineer = new Engineer(input[0], input[1], input[2], int.Parse(input[3]));
                        Console.WriteLine(inputEngineer);
                        Console.WriteLine($"Receives a salary {inputEngineer.GetSalary()}.");
                        break;

                    case "Junior":
                        Junior inputJunior = new Junior(input[0], input[1], input[2]);
                        Console.WriteLine(inputJunior);
                        Console.WriteLine($"Receives a salary {inputJunior.GetSalary()}.");
                        break;

                    default:
                        break;
                }

                input = Console.ReadLine().Split();
            }
        }
    }
}

