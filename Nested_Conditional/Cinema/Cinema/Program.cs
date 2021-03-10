using System;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string projection = Console.ReadLine().ToLower();
            int y = int.Parse(Console.ReadLine());
            int x = int.Parse(Console.ReadLine());

            int area = x * y;

            switch (projection)
            {
                case ("premiere"):    
                    Console.WriteLine($"{area * 12.00:f2}");
                    break;
                case ("normal"):
                    Console.WriteLine($"{area * 7.50:f2}");
                    break;
                case ("discount"):
                    Console.WriteLine($"{area * 5.00:f2}");
                    break;
            }


           // if (projection == "premiere")
          //      Console.WriteLine($"{area * 12.00:f2}");
           // else if (projection == "normal")
             //   Console.WriteLine($"{area * 7.50:f2}");
           // else if (projection == "discount")
               // Console.WriteLine($"{area * 5.00:f2}");


        }
    }
}
