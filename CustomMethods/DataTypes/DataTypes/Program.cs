using System;

namespace DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            string dataType = Console.ReadLine();
            string value = Console.ReadLine();
            DataAction(dataType, value);
        }

        static void DataAction(string dataType, string value)
        {
            switch (dataType)
            {
                case "int":
                    Console.WriteLine($"{Int32.Parse(value) * 2}");
                    break;
                case "real":
                    Console.WriteLine($"{(double.Parse(value) * 1.5):F2}");
                    break;
                case "string":
                    Console.WriteLine($"${value}$");
                    break;
                default:
                    break;
            }
        }
    }
}
