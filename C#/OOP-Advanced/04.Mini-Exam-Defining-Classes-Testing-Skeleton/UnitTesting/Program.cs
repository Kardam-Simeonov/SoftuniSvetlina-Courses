using System;

namespace UnitTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList shopingList = new ArrayList();
            shopingList.Add(4);
            shopingList.Add(2);
            shopingList.Add(4);
            shopingList.Add(4);
            shopingList.Add(3);
            shopingList.Add(8);

            Console.WriteLine(shopingList.CountFreePositions());
            shopingList.Cut(3);
            Console.WriteLine(shopingList.CountFreePositions());
            Console.WriteLine(shopingList.Change(3, 5));
        }
    }
}
