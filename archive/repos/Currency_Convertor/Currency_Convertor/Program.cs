using System;

namespace Currency_Convertor
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            string ent = Console.ReadLine();
            string ext = Console.ReadLine();


            if (ent == "BGN")
                money = money;

            else if (ent == "USD")
                money = money * 1.79549;

            else if (ent == "EUR")
                money = money * 1.95583;

            else if (ent == "GBP")
                money = money * 2.53405;



            if (ext == "BGN")
                money = money;

            else if (ext == "USD")
                money = money / 1.79549;

            else if (ext == "EUR")
                money = money / 1.95583;

            else if (ext == "GBP")
                money = money / 2.53405;

            Console.WriteLine(Math.Round(money,2));
        }
    }
}
